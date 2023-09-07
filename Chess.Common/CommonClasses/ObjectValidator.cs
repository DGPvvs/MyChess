namespace Chess.Common.CommonClasses
{
    using static Chess.Common.Constants.GlobalConstants.ErrorMessages;

    public static class ObjectValidator
    {
        public static void CheckIfObjectIsNull(object obj, string errorMessage = EmptyString)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj), errorMessage);
            }
        }
    }
}
