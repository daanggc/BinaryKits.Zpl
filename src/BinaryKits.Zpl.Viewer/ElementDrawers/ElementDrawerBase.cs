﻿using BinaryKits.Zpl.Label.Elements;
using SkiaSharp;

namespace BinaryKits.Zpl.Viewer.ElementDrawers
{
    public abstract class ElementDrawerBase : IElementDrawer
    {
        internal IPrinterStorage _printerStorage;
        internal SKCanvas _skCanvas;
        internal int _padding;

        public void Prepare(
            IPrinterStorage printerStorage,
            SKCanvas skCanvas,
            int padding)
        {
            this._printerStorage = printerStorage;
            this._skCanvas = skCanvas;
            this._padding = padding;
        }

        ///<inheritdoc/>
        public abstract bool CanDraw(ZplElementBase element);

        ///<inheritdoc/>
        public virtual bool IsReverseDraw(ZplElementBase element)
        {
            return false;
        }

        ///<inheritdoc/>
        public abstract void Draw(ZplElementBase element);
    }
}
