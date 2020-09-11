
namespace WritersCorner.Service.CustomException
{
    //TODO: to make different files
    public static class ExceptionMessage
    {
        public const string GlobalErrorMessage = "Ooops! Something whent wrong...";
        public const string NoNothing = "Our archives are empty about this subject. Are you sure you asked for the right thing?";

        //User
        public const string BanErrorMessage = "You cannot ban user that has already been banned.";
        public const string NoUser = "No user found.";

        //Site info
        public const string NoContactUs = "No contact us found.";
        public const string NoAboutUs = "No about us found.";
        public const string NoFAQ = "No FAQ found.";

        //Global
        public const string NoEdit = "You can't edit something that does not exist.";
        public const string NoDelete = "You can't delete something that does not exist in the first place.";

        //Character
        public const string NoCharacters = "No characters found.";

    }
}
