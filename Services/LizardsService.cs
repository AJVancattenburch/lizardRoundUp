namespace lizardRoundUp.Services;

public class LizardsService
{

  private readonly LizardsRepository _repo;
  public LizardsService(LizardsRepository repo)
  {
    _repo = repo;
  }

  public List<Lizard> GetAllLizards()
  {
    List<Lizard> lizards = _repo.GetAllLizards();
    return lizards;
  }

  internal Lizard CreateLizard(Lizard newLizard)
  {
    Lizard lizard = _repo.CreateLizard(newLizard);
    return lizard;
  }

  internal string RemoveLizard(int lizardId)
  {
    Lizard lizard = _repo.GetById(lizardId);
    if (lizard == null) throw new Exception($"No lizard at id:{lizardId}");

    _repo.RemoveLizard(lizardId);

    return $"und lizard was das delorted yah!!!";
  }

  internal Lizard UpdateLizard(Lizard updateData)
  {
    Lizard original = _repo.GetById(updateData.Id);
    if (original == null) throw new Exception($"No lizard at id:{updateData.Id}");

    original.Age = updateData.Age != null ? updateData.Age : original.Age;
    original.Name = updateData.Name != null ? updateData.Name : original.Name;
    original.HasCage = updateData.HasCage != null ? updateData.HasCage : original.HasCage;

    _repo.UpdateLizard(updateData);
    return updateData;
  }
}