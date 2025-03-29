using System;
using System.Collections.Generic;

namespace NCKH.Models;

public partial class PhanQuyen
{
    public int MaQuyen { get; set; }

    public string TenQuyen { get; set; } = null!;

    public virtual ICollection<NguoiDung> NguoiDungs { get; set; } = new List<NguoiDung>();
}
