using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Meep.Tech.Data.Examples.SimpleModelsWithOneFactory {
  public class Character : Model<Character>.WithComponents, IModel.IUseDefaultUniverse {

    [AutoBuild, Required, NotNull]
    public string Name {
      get;
      private set;
    }

    static Character() {
      Models<Character>.Factory = new(
        new(nameof(Character) + ".Test"),
        null,
        new() {
          Components<TestArchetypeData>.BuilderFactory.Make()
        },
        new Func<IBuilder, IModel.IComponent>[] {
          builder => Components<TestModelData>.BuilderFactory.Make()
        }
      ) {};
    }

    Character() { }
  }
}
