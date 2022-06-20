namespace TestingLayer
{
    [TestClass]
    public class PassportTests
    {
        private Card CARD;
        private Passport PASS;
        private PassportContext ctx = new PassportContext(MVRSystemDBManager.GetContext());
        [TestInitialize]
        public void Init()
        {
            this.CARD = new Card("passtest", "customegn", "none", "customfname", "custommname", "customlname", "m", "01.01.2001", "31.12.2050", "Plovdiv", "Plovdiv", "Plovdiv", "Plovdiv", "ul. Spas Tzilkov 5", 203, "black", "MVR Sofiq", "02.01.2021", "213213", "3123124", "3123123");
            this.PASS = new Passport("customid", CARD, "Sofia, Dubai");
            try
            {
                ctx.Delete("customid");
            }
            catch (Exception e) { }
            try
            {
                ctx.Create(PASS);
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
                ctx.Create(PASS);
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
            //Card newcard = new Card("custom2", "custom2", "none", "customfname", "custommname", "customlname", "m", "01.01.2001", "31.12.2050", "Plovdiv", "Plovdiv", "Plovdiv", "Plovdiv", "ul. Spas Tzilkov 5", 203, "black", "MVR Sofiq", "02.01.2021", "213213", "3123124", "3123123");
            Passport newpass = new Passport("customid", CARD, "Sofia, Dubai, Paris");
            ctx.Update(newpass);
            Assert.AreEqual("Sofia, Dubai, Paris", ctx.Read("customid").Destinations);
        }
        [TestMethod]
        public void DeleteTest()
        {
            ctx.Delete("customid");

            Assert.IsNull(ctx.Read("customid"));
        }

    }
}