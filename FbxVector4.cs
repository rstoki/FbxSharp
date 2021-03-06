﻿using System;

namespace FbxSharp
{
    public struct FbxVector4
    {
        public static readonly FbxVector4 Zero = new FbxVector4(0, 0, 0, 0);

        public FbxVector4(double pX, double pY, double pZ, double pW=1.0)
        {
            X = pX;
            Y = pY;
            Z = pZ;
            W = pW;
        }
        public FbxVector4(double[] pValue)
        {
            X = pValue[0];
            Y = pValue[1];
            Z = pValue[2];
            W = pValue[3];
        }
        public FbxVector4(FbxVector3 pValue, double pW=1.0)
        {
            X = pValue.X;
            Y = pValue.Y;
            Z = pValue.Z;
            W = pW;
        }

        public readonly double X;
        public readonly double Y;
        public readonly double Z;
        public readonly double W;

        public override string ToString()
        {
            return string.Format("{{X:{0} Y:{1} Z:{2} W:{3}}}", X, Y, Z, W);
        }

        public FbxVector3 ToVector3()
        {
            return new FbxVector3(X, Y, Z);
        }

        public double this [ int index ]
        {
            get
            {
                switch (index)
                {
                case 0: return X;
                case 1: return Y;
                case 2: return Z;
                case 3: return W;
                }

                throw new ArgumentOutOfRangeException("index", "index must be 0, 1, 2, or 3");
            }
            //set
            //{
            //    switch (index)
            //    {
            //    case 0: X = value; return;
            //    case 1: Y = value; return;
            //    case 2: Z = value; return;
            //    case 3: W = value; return;
            //    }
            //
            //    throw new ArgumentOutOfRangeException("index", "index must be 0, 1, 2, or 3");
            //}
        }


		/// <summary>
		/// Two FbxVector4s are equal iff all coordinates (X, Y, Z) are equal. 
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public bool Equals(FbxVector4 other)
	    {
		    return this.X.Equals(other.X) && this.Y.Equals(other.Y) && this.Z.Equals(other.Z) && this.W.Equals(other.W);
	    }

		/// <summary>
		/// Two FbxVector4s are equal iff all coordinates (X, Y, Z) are equal. 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
	    {
		    if (ReferenceEquals(null, obj)) return false;
		    return obj is FbxVector4 && this.Equals((FbxVector4) obj);
	    }

	    public override int GetHashCode()
	    {
		    unchecked {
			    var hashCode = this.X.GetHashCode();
			    hashCode = (hashCode*397) ^ this.Y.GetHashCode();
			    hashCode = (hashCode*397) ^ this.Z.GetHashCode();
			    hashCode = (hashCode*397) ^ this.W.GetHashCode();
			    return hashCode;
		    }
	    }
    }
}

