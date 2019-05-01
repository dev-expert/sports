using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Sports.Models;
using Sports.ViewModels;
using static Sports.Models.Model;

namespace Sports.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private SportsContext db;
        public HomeController(SportsContext context)
        {
            this.db = context;
        }
        public IActionResult TestList()
        {
            List<TestsList> testsLists = db.Tests.Include(x => x.TestTypes).ToList().Select(x => new TestsList()
            {
                TestId = x.TestId,
                Date = x.Date,
                NumberOfParticipants = db.TestSubscriptions.Where(a => a.TestID == x.TestId).Count(),
                TestType = x.TestTypes
            }).ToList();
            return View(testsLists != null ? testsLists : new List<TestsList>());
        }

        [Authorize(Roles = "Coach")]
        public IActionResult CreateTest()
        {
            ViewBag.ListOfTests = db.TestTypes.ToList();
            return View();
        }

        [Authorize(Roles = "Coach")]
        [HttpPost]
        public IActionResult CreateTest(TestsList testsList)
        {
            if (ModelState.IsValid)
            {
                Tests test = new Tests
                {
                    Date = testsList.Date,
                    TestTypeID = testsList.TestType.TestTypeId
                };

                db.Add(test);
                db.SaveChanges();
                if (test.TestId > 0)
                {
                    return RedirectToAction("Details", new { id = test.TestId });
                }
            }
            ViewBag.ListOfTests = db.TestTypes.ToList();
            ModelState.AddModelError("", "some thing went wrong");
            return View();
        }

        [Authorize(Roles = "Coach")]
        [HttpGet]
        public IActionResult Details(int id)
        {
            TestDetails testDetails = new TestDetails();
            testDetails.TestID = id;
            List<TestSubscriptionVM> testSubscriptions = db.TestSubscriptions.Include(x => x.Athletes).Where(x => x.TestID == id).ToList().Select(x => new TestSubscriptionVM
            {
                Distance = x.Distance,
                Ranking = x.Athletes?.AthleteName,
                TestSubscriptionID = x.TestSubscriptionID,
                TestID = x.TestID
            }).ToList();
            testDetails.testSubscriptions = testSubscriptions != null ? testSubscriptions : new List<TestSubscriptionVM>();
            return View(testDetails);
        }
        [Authorize(Roles = "Coach")]
        public IActionResult AddAthelete(int id)
        {

            ViewBag.ListOfAthletes = db.Athletes.Where(x => x.RoleId == 1).ToList().Select(x => new
            {
                Ranking = x.AthleteName,
                AtheleteId = x.AthleteId
            });
            TestSubscriptionVM testSubscription = new TestSubscriptionVM();
            testSubscription.TestID = id;
            return View(testSubscription);
        }

        [Authorize(Roles = "Coach")]
        [HttpPost("AddNewAthelete")]
        public IActionResult AddNewAthelete(TestSubscriptionVM testSubscription)
        {
            if (ModelState.IsValid)
            {
                TestSubscription Subscription = new TestSubscription
                {
                    Distance = testSubscription.Distance,
                    AthleteId = testSubscription.AtheleteId,
                    TestID = testSubscription.TestID
                };

                db.Add(Subscription);
                db.SaveChanges();
                if (Subscription.TestID > 0)
                {
                    return RedirectToAction("Details", new { id = Subscription.TestID });
                }
            }
            ViewBag.ListOfTests = db.TestTypes.ToList();
            ModelState.AddModelError("", "some thing went wrong");
            return View();
        }

        public IActionResult DeleteTest(int id)
        {
            Tests test = db.Set<Tests>().SingleOrDefault(c => c.TestId == id);
            if (test != null)
            {
                db.Entry(test).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                db.SaveChanges();
            }
            return RedirectToAction("TestList");
        }

        [HttpGet("editAthelete/{id?}")]
        public ActionResult editAthelete(int id)
        {
            ViewBag.ListOfAthletes = db.Athletes.Where(x => x.RoleId == 1).ToList().Select(x => new
            {
                Ranking = x.AthleteName,
                AtheleteId = x.AthleteId
            });

            TestSubscriptionVM testSubscription = db.TestSubscriptions.Where(x => x.TestSubscriptionID == Convert.ToInt32(id)).Select(x => new TestSubscriptionVM()
            {
                TestSubscriptionID = x.TestSubscriptionID,
                AtheleteId = x.Athletes.AthleteId,
                Distance = x.Distance,
                Ranking = x.Athletes.AthleteName,
            }).FirstOrDefault();

            return PartialView("editAthelete", testSubscription);
        } 

        public IActionResult DeleteAtheleteTest(int id, TestSubscriptionVM testSubscription)
        {
            TestSubscription test = db.Set<TestSubscription>().SingleOrDefault(c => c.TestSubscriptionID == testSubscription.TestSubscriptionID);
            if (test != null)
            {
                db.Entry(test).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                db.SaveChanges();
            }
            return RedirectToAction("Details", new { id = testSubscription.TestID });
        }

        public IActionResult updateAthelete(TestSubscriptionVM testSubscription)
        {
            TestSubscription data = db.TestSubscriptions.Where(s => s.TestSubscriptionID == testSubscription.TestSubscriptionID).FirstOrDefault();
            data.AthleteId = testSubscription.AtheleteId;
            data.Distance = testSubscription.Distance;
            db.SaveChanges();
            return RedirectToAction("Details", new { id = testSubscription.TestID });
        }
        //updateAthelete
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
