using Microsoft.Extensions.Logging;

namespace Logging.Logger;

public interface ILoggerAdapter<T> {
    void LogInformation(string message);
    void LogInformation<T0>(string message, T0 arg0);
    void LogInformation<T0, T1>(string message, T0 arg0, T1 arg1);
    void LogInformation<T0, T1, T2>(string message, T0 arg0, T1 arg1, T2 arg2);
}

public class LoggerAdapter<T> : ILoggerAdapter<T> {
    public void LogInformation(string message) {
        if (!_logger.IsEnabled(LogLevel.Information)) return;
        _logger.LogInformation(message);
    }

    public void LogInformation<T0>(string message, T0 arg0) {
        if (!_logger.IsEnabled(LogLevel.Information)) return;
        _logger.LogInformation(message, arg0);
    }

    public void LogInformation<T0, T1>(string message, T0 arg0, T1 arg1) {
        if (!_logger.IsEnabled(LogLevel.Information)) return;
        _logger.LogInformation(message, arg0, arg1);
    }

    public void LogInformation<T0, T1, T2>(string message, T0 arg0, T1 arg1, T2 arg2) {
        if (!_logger.IsEnabled(LogLevel.Information)) return;
        _logger.LogInformation(message, arg0, arg1, arg2);
    }

    private ILogger<T> _logger;
    public LoggerAdapter(ILogger<T> logger) {
        _logger = logger;
    }
}