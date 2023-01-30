// Interfaces

public interface TaxCalculator
{
  float CalculateTax();
}

public class TaxCalculator2021 : TaxCalculator
{

  public float CalculateTax()
  {
    return 1;
  }
}

public class TaxCalculator2022 : TaxCalculator
{
  public float CalculateTax()
  {
    return 2;
  }
}
