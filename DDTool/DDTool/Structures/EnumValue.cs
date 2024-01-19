namespace DDTool.Structures;

public class EnumValue {
    public string Desc { get; set; }
    public string Val { get; set; }

    public EnumValue(string desc, string val) {
        Desc = desc;
        Val = val;
    }
}
