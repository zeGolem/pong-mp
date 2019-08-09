using Microsoft.Xna.Framework;

namespace PongMP
{
    public class Utils
    {
        public static bool IsPointInRegion(Point point, Rectangle region)
        {
            return point.X > region.X
             && point.X < region.X + region.Width
             && point.Y > region.Y
             && point.Y < region.Y + region.Height;
        }
        public static bool AreRegionColliding(Rectangle firstRegion, Rectangle secondRegion)
        {
            return firstRegion.X + firstRegion.Width > secondRegion.X
             && firstRegion.X < secondRegion.X + secondRegion.Width
             && firstRegion.Y + firstRegion.Height > secondRegion.Y
             && firstRegion.Y < secondRegion.Y + secondRegion.Height;
        }

        public enum Sides
        {
            Top, Left, Bottom, Right, None
        }

        public enum Orientations
        {
            Horizontal, Vertical, None
        }

        public static Orientations GetColisionOrientation(Rectangle target, Rectangle region)
        {
            if (target.X + target.Width > region.X && target.X < region.X + region.Width)
            {
                return Orientations.Horizontal;
            }
            if (target.Y + target.Height > region.Y && target.Y < region.Y + region.Height)
            {
                return Orientations.Horizontal;
            }
            return Orientations.None;
        }

        public static bool IsInBounds(Rectangle target, Rectangle bounds) {
            return target.X >= bounds.X && target.X + target.Width <= bounds.Width
                    && target.Y >= bounds.Y && target.Y + target.Height <= bounds.Height;
        }

        // public static Sides GetSideFacingTarget(Rectangle target, Rectangle region) {
        //     if (target.X > region.X) {
        //         return Sides.Right;
        //     }
        //     if ()
        //     return Sides.None;
        // }
    }
}