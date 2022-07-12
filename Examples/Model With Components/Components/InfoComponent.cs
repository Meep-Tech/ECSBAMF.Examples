using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Meep.Tech.Data.Examples.ModelWithComponents {
  public class InfoComponent : Archetype.IComponent<InfoComponent>, IComponent.IUseDefaultUniverse, Archetype.IComponent.IAmLinkedTo<InfoComponent.Data> {

    [AutoBuild, Required, NotNull]
    [TestValue("Test Description")]
    public string DefaultText {
      get;
      private set;
    }

    Data Archetype.IComponent.IAmLinkedTo<Data>.BuildDefaultModelComponent(Meep.Tech.Data.IModel.Builder parentModelBuilder, Meep.Tech.Data.Universe universe)
      => new Data { Text = DefaultText };

    [TestParentFactory(typeof(MiniBuiltCapacitor.Type))]
    public class Data : IModel.IComponent<Data>, IComponent.IUseDefaultUniverse {

      [AutoBuild(ParameterName = "InfoComponent.Text", DefaultArchetypePropertyName = nameof(DefaultText))]
      public string Text {
        get;
        internal set;
      }
    }
  }
}
