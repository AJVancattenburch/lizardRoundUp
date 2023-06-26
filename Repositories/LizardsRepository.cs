namespace lizardRoundUp.Repositories;

public class LizardsRepository
{
  private List<Lizard> dbLizards;

  public LizardsRepository()
  {
    this.dbLizards = new List<Lizard> { };
    dbLizards.Add(new Lizard("Chamas", 1, "Green", true, true, 1));
    dbLizards.Add(new Lizard("Iggy", 3, "Green & Blue", false, true, 2));
    dbLizards.Add(new Lizard("Lizard Macguire", 5, "Yellow", true, true, 3));
  }

  internal List<Lizard> GetAllLizards()
  {
    return dbLizards;
  }
  internal Lizard GetById(int lizardId)
  {
    Lizard lizard = dbLizards.Find(l => l.Id == lizardId);
    return lizard;
  }
  internal Lizard CreateLizard(Lizard newLizard)
  {
    int lastId = dbLizards[dbLizards.Count - 1].Id;
    newLizard.Id = lastId + 1;
    dbLizards.Add(newLizard);
    return newLizard;
    //NOTE would this also work???
    // newLizard.Id = dbLizards.Count + 1;
    // dbLizards.Add(newLizard);
    // return newLizard;
  }

  internal void RemoveLizard(int lizardId)
  {
    Lizard lizard = dbLizards.Find(l => l.Id == lizardId);
    dbLizards.Remove(lizard);
  }

  internal void UpdateLizard(Lizard updateData)
  {
    Lizard lizard = GetById(updateData.Id);
    lizard = updateData;
  }
}