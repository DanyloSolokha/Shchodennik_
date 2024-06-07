public class BasicTask
{

  public BasicTask()
  {

  }

  private string _description = "Нова справа";
  public string Description
  {
    get { return _description; }
    set { _description = value; }
  }

  private string _note = "...";
  public string Note
  {
    get { return _note; }
    set { _note = value; }
  }

  private string _location = "...";
  public string Location
  {
    get { return _location; }
    set { _location = value; }
  }

  private bool _done = false;
  public bool Done
  {
    get { return _done; }
    set
    {
      _done = value;
      if (value == true) UpdateSubTasksDone(value);
    }
  }

  private List<BasicTask> _subTasks = new List<BasicTask>();

  public List<BasicTask> SubTasks
  {
    get
    {
      return _subTasks;
    }
    set
    {
      _subTasks = value;
    }
  }

  public void AddSubTask(BasicTask subTask)
  {
    this._subTasks.Add(subTask);
  }

  public virtual void AddToHolder()
  {
    DataHolder.BasicTaskList.Add(this);
  }

  public virtual void RemoveFromHolder()
  { 
    DataHolder.BasicTaskList.Remove(this);
  }

  public void UpdateBasicProperty(string description, string note, string location)
  {
    description = description.Trim();
    note = note.Trim();
    location = location.Trim();

    if (description.Length == 0) this.Description = "Без назви";
    else this.Description = description;

    if (note.Length == 0) this.Note = "...";
    else this.Note = note;

    if (location.Length == 0) this.Location = "...";
    else this.Location = location;
  }

  private void UpdateSubTasksDone(bool done)
  {
    foreach (var subTask in this.SubTasks)
    {
      subTask.Done = done;
      subTask.UpdateSubTasksDone(done);
    }
  }

    public BasicTask DeepCopy()
    {
        BasicTask copy = new BasicTask
        {
            Description = this.Description,
            Note = this.Note,
            Location = this.Location,
            Done = this.Done
        };

        foreach (var subTask in this.SubTasks)
        {
            copy.AddSubTask(subTask.DeepCopy());
        }

        return copy;
    }
}
