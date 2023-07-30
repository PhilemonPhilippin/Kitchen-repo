namespace Kitchen.Dal.Tools;

public static class LogMessageHandler
{
    public static void LogCriticalExist(this ILogger logger, string entityName, int  id, Exception ex)
    {
        logger.LogCritical("While querying if {EntityName} exist for id = {Id}, error = {Ex}", entityName, id, ex);
    }

    public static void LogCriticalGet(this ILogger logger, string entityName, int id, Exception ex)
    {
        logger.LogCritical("While getting a {EntityName} with id = {Id} in DB, error = {Ex}", entityName, id, ex);
    }

    public static void LogCriticalGetAll(this ILogger logger, string entityName, Exception ex)
    {
        logger.LogCritical("While getting the {EntityName}s in DB, error = {Ex}", entityName, ex);
    }

    public static void LogCriticalAdd(this ILogger logger, string entityName, Exception ex)
    {
        logger.LogCritical("While adding a {EntityName} in DB, error = {Ex}", entityName, ex);
    }

    public static void LogCriticalUpdate(this ILogger logger, string entityName, int id, Exception ex)
    {
        logger.LogCritical("While updating a {EntityName} with id = {Id} in DB, error = {Ex}", entityName, id, ex);
    }

    public static void LogCriticalDelete(this ILogger logger, string entityName, int id, Exception ex)
    {
        logger.LogCritical("While deleting a {EntityName} with id = {Id} in DB, error = {Ex}", entityName, id, ex);
    }

    public static void LogCriticalSaveChanges(this ILogger logger, string entityName, Exception ex)
    {
        logger.LogCritical("While saving changes to the DB for entity = {EntityName} in DB, exception = {Ex}", entityName, ex);
    }
}
