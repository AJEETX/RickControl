public class Role: BaseEntity
{
    public string Name {get; set;}
    public string Code {get; set;}
    public virtual User User {get; set;}
}