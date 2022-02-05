using Microsoft.AspNetCore.Mvc;

namespace RestWithAspNetUdemy.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private const string Error = "Invalid Input";
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult Sum(string firstNumber, string secondNumber)
    {
        if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
            return Ok(sum.ToString());
        }
        return BadRequest(Error);
    }

    [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
    public IActionResult Subtraction(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
            return Ok(sub.ToString());
        }
        return BadRequest(Error);
    }

    [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
    public IActionResult Multiplication(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var multi = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
            return Ok(multi.ToString());
        }
        return BadRequest(Error);
    }

    [HttpGet("division/{firstNumber}/{secondNumber}")]
    public IActionResult Division(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var multi = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
            return Ok(multi.ToString());
        }
        return BadRequest(Error);
    }

    [HttpGet("mean/{firstNumber}/{secondNumber}")]
    public IActionResult Mean(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var mean = (ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber)) / 2 ;
            return Ok(mean.ToString());
        }
        return BadRequest(Error);
    }

    [HttpGet("square/{firstNumber}")]
    public IActionResult Square(string firstNumber)
    {
        if (IsNumeric(firstNumber))
        {
            var square = Math.Sqrt((double)ConvertToDecimal(firstNumber));
            return Ok(square.ToString());
        }
        return BadRequest(Error);
    }

    private decimal ConvertToDecimal(string strNumber)
    {
        decimal decimalValue;
        if(decimal.TryParse(strNumber, out decimalValue))
        {
            return decimalValue;
        }
        return 0;
    }

    private bool IsNumeric(string strNumber)
    {
        double numero;
        bool isNumber = double.TryParse(
            strNumber, System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo,
            out numero);
        return isNumber;
    }
}
