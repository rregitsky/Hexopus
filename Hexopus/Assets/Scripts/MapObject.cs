using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class MapObject
    {
        private List<MapPieceObject> mapPieceList;

        public MapObject(List<MapPieceObject> mapPieceList)
        {
            this.mapPieceList = mapPieceList;
        }
    }
}
