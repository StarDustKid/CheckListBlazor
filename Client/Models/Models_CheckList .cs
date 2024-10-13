using System;
using System.Collections.Generic;

public class CheckList
{
    public string Id { get; set; }
    public List<CheckObject> ListItems { get; set; } = new List<CheckObject>();
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastModified { get; set; }
}

public class CheckObject
{
    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int EstimatedTime_Minute { get; set; }
}