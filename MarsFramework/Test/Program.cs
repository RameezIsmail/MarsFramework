﻿using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test, Order (1)]
            public void AddShareskill()
            {

                ShareSkill shareskillobj = new ShareSkill();
                Base.test = Base.extent.StartTest("ShareSkill Add Test");
                shareskillobj.EnterShareSkill();

            }

            [Test, Order (2)]
            public void EditShareSkill()
            {
                Base.test = Base.extent.StartTest("ShareSkill Edit");
                ManageListings Manageobj = new ManageListings();
                Manageobj.EditListings();

                ShareSkill editshareskillobj = new ShareSkill();
                editshareskillobj.EditShareSkill();

            }

            [Test, Order (3)]
            public void ManageListing()
            {
                Base.test = Base.extent.StartTest("View and Delete");
                ManageListings ManageListingsobj = new ManageListings();
                ManageListingsobj.Listings();
            }

        }
    }
}