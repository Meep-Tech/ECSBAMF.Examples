using System;

namespace Meep.Tech.Data.Examples.SimpleModelsWithOneFactory {
  public class WorldFactory : IModel<World>.BuilderFactory {
    internal WorldFactory() 
      : base(
        new(nameof(WorldFactory)),
        null,
        new() {
          Components<TestArchetypeData>.BuilderFactory.Make()
        },
        new Func<IBuilder, IModel.IComponent>[] {
          builder => Components<TestModelData>.BuilderFactory.Make()
        }
      ) {}
  }
}
