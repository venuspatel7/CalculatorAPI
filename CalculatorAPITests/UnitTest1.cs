using MyApp.Namespace;

using Microsoft.AspNetCore.Mvc;


namespace CalculatorAPITests;

[TestClass]
public class UnitTest1
{
    
    //addition..............................................
[TestMethod]
        public void TestAddsimplenumber()
        {

            CalculatorController controller = new CalculatorController();

            
            decimal a = 5;
            decimal b = 3;

            
            var result = controller.Add(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(8, (decimal)(result as OkObjectResult).Value);
        }
        [TestMethod]
        public void TestAddWithNegativeNumbers()
        {
             CalculatorController controller = new CalculatorController();

            decimal a = -5;
            decimal b = -3;

            
            var result = controller.Add(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(-8, (decimal)(result as OkObjectResult).Value);
        }

        [TestMethod]
        public void TestAddWithZero()
        {
             CalculatorController controller = new CalculatorController();

            
            decimal a = 5;
            decimal b = 0;

            
            var result = controller.Add(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(5, (decimal)(result as OkObjectResult).Value);
        }

        [TestMethod]
        public void TestAddWithLargeNumbers()
        {
             CalculatorController controller = new CalculatorController();

            
            decimal a = 10000000000000000000m; // 
            decimal b = 20000000000000000000m; // 

            
            var result = controller.Add(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(30000000000000000000m, (decimal)(result as OkObjectResult).Value); // 
        }

        [TestMethod]
        public void TestAddWithDecimalNumbers()
        {
             CalculatorController controller = new CalculatorController();

            
            decimal a = 3.14m;
            decimal b = 2.86m;

            
            var result = controller.Add(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(6m, (decimal)(result as OkObjectResult).Value);
        }

        //subtraction method............................................
        [TestMethod]
        public void TestSubtract()
        {
               CalculatorController controller = new CalculatorController();
            
            decimal a = 5;
            decimal b = 3;

            
            var result = controller.Subtract(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(2, (decimal)(result as OkObjectResult).Value);
        }
         [TestMethod]
        public void TestSubtractNegativeResult()
        {
            
               CalculatorController controller = new CalculatorController();
            
            decimal a = 3;
            decimal b = 5;

            
            var result = controller.Subtract(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(-2, (decimal)(result as OkObjectResult).Value);
        }

        [TestMethod]
        public void TestSubtractWithZero()
        {
            
               CalculatorController controller = new CalculatorController();
            
            decimal a = 5;
            decimal b = 0;

            
            var result = controller.Subtract(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(5, (decimal)(result as OkObjectResult).Value);
        }

        [TestMethod]
        public void TestSubtractWithNegativeZero()
        {
            
               CalculatorController controller = new CalculatorController();
            
            decimal a = 5;
            decimal b = -0;

            
            var result =controller.Subtract(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(5, (decimal)(result as OkObjectResult).Value);
        }

        [TestMethod]
        public void TestSubtractWithNegativeValues()
        {
            
               CalculatorController controller = new CalculatorController();
            
            decimal a = -5;
            decimal b = -3;

            
            var result = controller.Subtract(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(-2, (decimal)(result as OkObjectResult).Value);
        }
        //multiplication..............................................
        [TestMethod]
public void TestMultiplyPositiveNumbersReturnsCorrectResult()
{
    
    CalculatorController controller = new CalculatorController();
    decimal a = 5;
    decimal b = 3;

    
    var result = controller.Multiply(a, b);

    
    Assert.IsNotNull(result);
    Assert.AreEqual(15, (decimal)(result as OkObjectResult).Value);
}

[TestMethod]
public void TestMultiplyNegativeNumbersReturnsCorrectResult()
{
    
    CalculatorController controller = new CalculatorController();
    decimal a = -5;
    decimal b = -3;

    
    var result = controller.Multiply(a, b);

    
    Assert.IsNotNull(result);
    Assert.AreEqual(15, (decimal)(result as OkObjectResult).Value);
}

[TestMethod]
public void TestMultiplyPositiveAndNegativeNumbersReturnsCorrectResult()
{
    
    CalculatorController controller = new CalculatorController();
    decimal a = -5;
    decimal b = 3;

    
    var result = controller.Multiply(a, b);

    
    Assert.IsNotNull(result);
    Assert.AreEqual(-15, (decimal)(result as OkObjectResult).Value);
}

[TestMethod]
public void TestMultiplyByZeroReturnsZero()
{
    
    CalculatorController controller = new CalculatorController();
    decimal a = 5;
    decimal b = 0;

    
    var result = controller.Multiply(a, b);

    
    Assert.IsNotNull(result);
    Assert.AreEqual(0, (decimal)(result as OkObjectResult).Value);
}
[TestMethod]
public void TestMultiplyDecimalNumbersReturnsCorrectResult()
{
    
    CalculatorController controller = new CalculatorController();
    decimal a = 3.5m;
    decimal b = 2.5m;

    
    var result = controller.Multiply(a, b);

    
    Assert.IsNotNull(result);
    Assert.AreEqual(8.75m, (decimal)(result as OkObjectResult).Value);
}
//division...............................................
[TestMethod]
  public void TestDivide()
        {
             CalculatorController controller = new CalculatorController();
   
            decimal a = 6;
            decimal b = 3;

            
            var result = controller.Divide(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(2, (decimal)(result as OkObjectResult).Value);
        }
        [TestMethod]
    public void TestDivide1()
        {
             CalculatorController controller = new CalculatorController();
   
            decimal a = 3;
            decimal b = 3;

            
            var result = controller.Divide(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(1, (decimal)(result as OkObjectResult).Value);
        }
    [TestMethod]
    public void TestDivide4()
        {
             CalculatorController controller = new CalculatorController();
   
            decimal a = 8;
            decimal b = 4;

            
            var result = controller.Divide(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(2, (decimal)(result as OkObjectResult).Value);
        }

               [TestMethod]
    public void TestDivide3()
        {
             CalculatorController controller = new CalculatorController();
   
            decimal a = 32;
            decimal b = 8;

            
            var result = controller.Divide(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(4, (decimal)(result as OkObjectResult).Value);
        }
    [TestMethod]
    public void TestDivide2()
        {
             CalculatorController controller = new CalculatorController();
   
            decimal a = 8;
            decimal b = 2;

            
            var result = controller.Divide(a, b);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(4, (decimal)(result as OkObjectResult).Value);
        }

}
