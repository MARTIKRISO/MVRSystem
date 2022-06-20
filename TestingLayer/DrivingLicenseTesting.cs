namespace TestingLayer
{
    [TestClass]
    public class DrivingLicenseTests
    {
        private DrivingLicenseContext ctx = new DrivingLicenseContext(MVRSystemDBManager.GetContext());
        private DrivingLicense? LICENSE;
        [TestInitialize]
        public void Init()
        {

            Card CARD = new Card("id", "egn", "none", "customfname", "custommname", "customlname", "m", "01.01.2001", "31.12.2050", "Plovdiv", "Plovdiv", "Plovdiv", "Plovdiv", "ul. Spas Tzilkov 5", 203, "black", "MVR Sofiq", "02.01.2021", "213213", "3123124", "3123123");
            DrivingLicense LICENSE = new DrivingLicense("customid", "customegn", CARD, 69, "B");
            this.LICENSE = LICENSE;
            
            try
            {
                ctx.Delete("customid");
            }
            catch (Exception e) { }
            try
            { 
                ctx.Create(LICENSE);
            }
            catch (Exception e) { }
        }
        [TestCleanup]
        public void CleanUp()
        {
            try
            {
                ctx.Delete("customid");
            }
            catch (Exception e) { }
            try
            {
                ctx.Create(LICENSE);
            }
            catch (Exception e) { }
        }

        [TestMethod]
        public void CreateTest()
        {
            Assert.IsNotNull(ctx.Read("customid"));
        }
        [TestMethod]
        public void ReadTest()
        {
            Assert.IsNotNull(ctx.Read("customid"));
        }
        [TestMethod]
        public void ReadAllTest()
        {
            Assert.IsNotNull(ctx.ReadAll());
        }
        [TestMethod]
        public void UpdateTest()
        {
            var cardcontext = new CardContext(MVRSystemDBManager.GetContext());
            try
            {
                cardcontext.Delete("newcard");
            }
            catch (Exception e) { }
            Card card = new Card("newcard", "egn2", "none", "customfname", "custommname", "customlname", "m", "01.01.2001", "31.12.2050", "Plovdiv", "Plovdiv", "Plovdiv", "Plovdiv", "ul. Spas Tzilkov 5", 203, "black", "MVR Sofiq", "02.01.2021", "213213", "3123124", "3123123");
            cardcontext.Create(card);
            DrivingLicense newlic = new DrivingLicense("customid", "egn2", card, 68, "C");
            ctx.Update(newlic);
            Assert.AreEqual("egn2", ctx.Read("customid").EGN);
        }
        [TestMethod]
        public void DeleteTest()
        {
            ctx.Delete("customid");

            Assert.IsNull(ctx.Read("customid"));
        }
      
    }
}