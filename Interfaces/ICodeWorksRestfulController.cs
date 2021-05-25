using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Interfaces
{
  public interface ICodeWorksRestfulController<T>
  {
    ActionResult<IEnumerable<T>> GetAll();
    ActionResult<T> GetById();
    ActionResult<T> Create();
    ActionResult<T> Update();
    ActionResult<T> Delete();
  }
}