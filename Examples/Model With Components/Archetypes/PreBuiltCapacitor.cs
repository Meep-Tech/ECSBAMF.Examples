using System;
using System.Collections.Generic;
using System.Text;

namespace Meep.Tech.Data.Examples.ModelWithComponents {

  public class PreBuiltCapacitor : FluxCapacitor.Type {

    protected override IReadOnlyDictionary<string, IComponent> InitialComponents 
      => base.InitialComponents
        .Append(Components<InfoComponent>.BuilderFactory.Make((nameof(InfoComponent.DefaultText),  "Default Info")));

    protected override IReadOnlyDictionary<string, Func<IBuilder, IModel.IComponent>> InitialUnlinkedModelComponents 
      => base.InitialUnlinkedModelComponents
        .Append<CapacitorDetector>()
        .Append<DisplayComponent>();

    protected PreBuiltCapacitor() : base(new(nameof(PreBuiltCapacitor))) { }
  }
}
