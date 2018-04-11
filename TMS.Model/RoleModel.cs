namespace TMS.Model
{
    public class RoleModel
    {

        public int Id { get; set; }

        public string RoleName { get; set; }
        public RoleModel(int id, string roleName)
        {
            this.Id = id;
            this.RoleName = roleName;
        }
        public override string ToString()
        {
            return $"{this.Id}, {this.RoleName}";
        }
    }
}