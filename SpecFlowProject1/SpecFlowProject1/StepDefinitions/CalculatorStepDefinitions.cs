namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        Calculator_Class Calc_Obj = new Calculator_Class();
        public int actual_result;
        //Addition
        [Given(@"First number for addition is (.*)")]   public void GivenFirstNumberForAdditionIs(int first)   {   Calc_Obj.first_number_var = first;                        }   
        
        [Given(@"Second number for addition is (.*)")]  public void GivenSecondNumberForAdditionIs(int second)  {   Calc_Obj.second_number_var = second;                       }

        [When(@"the two numbers are added")]             public void WhenTheTwoNumberAreAdded()              {   actual_result = Calc_Obj.Addition_Func();              }

        [Then(@"Result for addition should be (.*)")]   public void ThenResultForAdditionShouldBe(int expected_result)   {   actual_result.Should().Be(expected_result);                         }


        //Subtraction
        [Given(@"First number for Subtraction is (.*)")] public void GivenFirstNumberForSubtractionIs(int first) { Calc_Obj.first_number_var = first; }

        [Given(@"Second number for Subtraction is (.*)")] public void GivenSecondNumberForSubtractionIs(int second) { Calc_Obj.second_number_var = second; }

        [When(@"the two number are subtracted")] public void WhenTheTwoNumberAreSubtracted() { actual_result = Calc_Obj.Subtraction_Func(); }

        [Then(@"Result for subtraction should be (.*)")] public void ThenResultForSubtractionShouldBe(int expected_result) { actual_result.Should().Be(expected_result); }


        //Multiplication
        [Given(@"First number for Multiplication operation is (.*)")] public void GivenFirstNumberForMultiplicationOperationIs(int first) { Calc_Obj.first_number_var = first; }

        [Given(@"Second number for Multiplication operation is (.*)")] public void GivenSecondNumberForMultiplicationOperationIs(int second) { Calc_Obj.second_number_var = second; }

        [When(@"the two number are multiply")] public void WhenTheTwoNumberAreMultiply() { actual_result = Calc_Obj.Multiplication_Func(); }

        [Then(@"Result for multiplication should be (.*)")] public void ThenResultForMultiplicationShouldBe(int expected_result) { actual_result.Should().Be(expected_result); }


        //Division
        [Given(@"First number for Division operation is (.*)")] public void GivenFirstNumberForDivisionOperationIs(int first) { Calc_Obj.first_number_var = first; }

        [Given(@"Second number for Division operation is (.*)")] public void GivenSecondNumberForDivisionOperationIs(int second) { Calc_Obj.second_number_var = second; }

        [When(@"the two number are divided")] public void WhenTheTwoNumberAreDivided() { actual_result = Calc_Obj.Division_Func(); }

        [Then(@"Result for division should be (.*)")] public void ThenResultForDivisionShouldBe(int expected_result) { actual_result.Should().Be(expected_result); }
    }
}