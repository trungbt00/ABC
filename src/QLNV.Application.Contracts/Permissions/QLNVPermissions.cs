namespace QLNV.Permissions;

public static class QLNVPermissions
{
    public const string GroupName = "QLNV";

    public static class HR
    {
        public const string Default = GroupName + ".HR";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
}
