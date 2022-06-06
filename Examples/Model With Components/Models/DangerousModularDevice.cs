namespace Meep.Tech.Data.Examples.ModelWithComponents {
  /// <summary>
  /// Dangerous version, lets you delete things.
  /// </summary>
  public partial class DangerousModularDevice 
    : SafeModularDevice, 
      IWriteableComponentStorage 
  { }
}
