namespace TestingLayer
{
    [TestClass]
    public class DrivingLicenseTests
    {
      /*  private DrivingLicenseContext ctx = new DrivingLicenseContext(MVRSystemDBManager.GetContext());
        private DrivingLicense? LICENSE;
        [TestInitialize]
        public void Init()
        {
            Card CARD = new Card("customid", "customegn", "none", "customfname", "custommname", "customlname", "m", "01.01.2001", "31.12.2050", "Plovdiv", "Plovdiv", "Plovdiv", "Plovdiv", "ul. Spas Tzilkov 5", 203, "black", "MVR Sofiq", "02.01.2021", "213213", "3123124", "3123123");
            DrivingLicense LICENSE = new DrivingLicense(CARD, 69, "B");
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
                ctx.Create(CARD);
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
            Card Spas = new Card("customid", "customegn", "none", "spas", "custommname", "customlname", "f", "01.01.2001", "31.12.2050", "Plovdiv", "Plovdiv", "Plovdiv", "Plovdiv", "ul. Spas Tzilkov 5", 203, "black", "MVR Sofiq", "02.01.2021", "213213", "3123124", "3123123");
            ctx.Update(Spas);
            Assert.AreEqual("spas", ctx.Read("customid").FirstName);
        }
        [TestMethod]
        public void DeleteTest()
        {
            ctx.Delete("customid");

            Assert.IsNull(ctx.Read("customid"));
        }
      */
    }
}