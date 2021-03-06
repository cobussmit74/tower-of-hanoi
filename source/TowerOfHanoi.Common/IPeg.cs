﻿using System.Collections.Generic;

namespace TowerOfHanoi.Common
{
  public interface IReadonlyPeg
  {
    int MaxDiscs { get; }
    int CurrentNumberOfDiscs { get; }
    IDisc TopDisc { get; }
    IEnumerable<IDisc> AllDiscs();
  }

  public interface IPeg : IReadonlyPeg
  {
    IDisc TakeTopDisc();
    void PlaceDisc(IDisc disc);
  }
}