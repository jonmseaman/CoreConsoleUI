﻿namespace NetCoreTUI.Controls
{
    public class Rectangle : Control
    {
        protected override void DrawBorder()
        {
            base.DrawBorder();
        }

        protected override void DrawControl()
        {
            if (!ShouldDraw)
                return;

            var x = ClientLeft;

            while (x <= ClientRight)
            {
                var y = ClientTop;

                while (y <= ClientBottom)
                {
                    Owner.Buffer.Write((short)x, (short)y, ' ', ForegroundColor, BackgroundColor);

                    y++;
                }

                x++;
            }
        }
    }
}