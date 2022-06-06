namespace Meep.Tech.Data.Examples.ModelWithComponents {
  public struct CapacitorData 
    : IModel.IComponent<CapacitorData>,
      IComponent.IUseDefaultUniverse
  {

    public int Value;

    public CapacitorData(int value) : this() {
      Value = value;
    }
  }
}
