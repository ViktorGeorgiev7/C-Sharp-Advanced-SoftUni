using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public interface IBox
    {
        double Length { get;}
        double Width { get;}
        double Height { get;}
        double SurfaceArea();
        double LateralSurfaceArea();
        double Volume();
    }
}
