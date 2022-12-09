
//namespace StringCalculator;

//public class StringCalculator
//{

//    public int Add(string str)
//    {
//        int num = 0;
//        if (str.Contains(',') || str.Contains("\n,"))
//        {
//            string[] nums = str.Contains(',') ? str.Split(',') : str.Split("\n,");
//            for (int i = 0; i < nums.Length; i++)
//            {
//                Int32.TryParse(nums[i], out int n);
//                num += n;
//            }
//        }
//        else
//        {
//            Int32.TryParse(str, out num);
//        }  
//        return num;
//    }
//}



using Castle.Core.Logging;

namespace StringCalculator;

public class StringCalculator
{
    private readonly ILogger _logger;
    private readonly IWebService _webService;

    public StringCalculator(IWebService webService, ILogger logger)
    {
        _webService = webService;
        _logger = logger;
    }

    public int Add(string numbers)
    {
        var answer = numbers == "" ? 0 : numbers.Split(',', '\n').Select(int.Parse).Sum();

        try
        {
            _logger.Write(answer.ToString());
        }
        catch (LoggerException ex)
        {
            _webService.Notify(ex.Message);
        }
        
        return answer;

    }
}


