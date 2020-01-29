﻿using ClangPowerTools.MVVM.Interfaces;

namespace ClangPowerTools.MVVM.Models
{
  public class FormatOptionModel : IFormatOption
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Paramater { get; set; } = string.Empty;
    public string Input { get; set; } = string.Empty;
    public bool HasToogleButton { get; } = false;
    public bool HasTextBox { get; } = true;
  }
}
