using Kitchen.Entities;

namespace Kitchen.Api.Tools
{
    public static class LogMessageHandler
    {
        #region GetAll and Get
        public static void LogInformationGetAll(this ILogger logger, string entityName)
        {
            logger.LogInformation("{EntityName}s were not found.", entityName);
        }

        public static void LogCriticalGetAll(this ILogger logger, string entityName, Exception ex)
        {
            logger.LogCritical("While getting the {EntityName}s, error = {Ex}", entityName, ex);
        }

        public static void LogCriticalGetAllForSpecificRecipe(this ILogger logger, string entityName, int recipeId, Exception ex)
        {
            logger.LogCritical("While getting {EntityName}s for recipe id = {RecipeId}, error = {Ex}", entityName, recipeId, ex);
        }

        public static void LogInformationGet(this ILogger logger, string entityName, int id)
        {
            logger.LogInformation("{EntityName} with id = {Id} was not found.", entityName, id);
        }

        public static void LogCriticalGet(this ILogger logger, string entityName, int id, Exception ex)
        {
            logger.LogCritical("While getting a {EntityName} with id = {Id}, error = {Ex}", entityName, id, ex);
        }
        #endregion

        #region Create

        public static void LogInformationCreate(this ILogger logger, string entityName, string title)
        {
            logger.LogInformation("{EntityName} with title = {Title} could not be created.", entityName, title);
        }

        public static void LogCriticalCreate(this ILogger logger, string entityName, string title, Exception ex)
        {
            logger.LogCritical("While creating a {EntityName} with title = {Title}, error = {Ex}", entityName, title, ex);
        }
        #endregion

        #region Update

        public static void LogInformationUpdate(this ILogger logger, string entityName, int id)
        {
            logger.LogInformation("{EntityName} with id = {Id} could not be updated.", entityName, id);
        }

        public static void LogCriticalUpdate(this ILogger logger, string entityName, int id, Exception ex)
        {
            logger.LogCritical("While updating a {EntityName} with id = {Id}, error = {Ex}", entityName, id, ex);
        }

        public static void LogCriticalUpdateForSpecificRecipe(this ILogger logger, string entityName, int recipeId, int entityId, Exception ex)
        {
            logger.LogCritical("While updating a {EntityName} for recipe id = {RecipeId} and {EntityName} id = {EntityId}, error = {Ex}", entityName, recipeId, entityName, entityId, ex);
        }
        #endregion

        #region Delete
        public static void LogInformationDelete(this ILogger logger, string entityName, int id)
        {
            logger.LogInformation("{EntityName} with id = {Id} could not be deleted.", entityName, id);
        }

        public static void LogCriticalDelete(this ILogger logger, string entityName, int id, Exception ex)
        {
            logger.LogCritical("While deleting a {EntityName} with id = {Id}, error = {Ex}", entityName, id, ex);
        }

        public static void LogCriticalDeleteForSpecificRecipe(this ILogger logger, string entityName, int recipeId, int entityId, Exception ex)
        {
            logger.LogCritical("While deleting a {EntityName} for recipe id = {RecipeId} and {EntityName} id = {EntityId}, error = {Ex}",entityName, recipeId, entityName, entityId, ex);
        }
        #endregion
    }
}
