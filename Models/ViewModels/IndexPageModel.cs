
using System;

namespace police.Models.ViewModels {
  public class IndexPageViewModel {
    // this is where you create the variables that you will use in your view.
    public DateTime Date {get; set;}

    // the controller actually binds the model to the view
    public IndexPageViewModel() {
      Date = DateTime.Now;
    }
  }
}
