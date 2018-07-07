using System;

namespace FbxSharp
{
    public struct FbxVector2
    {
        public FbxVector2(double pX, double pY)
        {
            X = pX;
            Y = pY;
        }
        public FbxVector2(double[] pValue)
        {
            X = pValue[0];
            Y = pValue[1];
        }

        public readonly double X;
        public readonly double Y;

        public override string ToString()
        {
            return string.Format("{{X:{0} Y:{1}}}", X, Y);
        }


	    public bool Equals(FbxVector2 other)
	    {
		    return this.X.Equals(other.X) && this.Y.Equals(other.Y);
	    }


		/// <summary>
		/// Two FbxVector2s are equals iff both coordinates (X, Y) are equal. 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
	    public override bool Equals(object obj)
	    {
		    if (ReferenceEquals(null, obj)) return false;
		    return obj is FbxVector2 && this.Equals((FbxVector2) obj);
	    }

	    public override int GetHashCode()
	    {
		    unchecked {
			    return (this.X.GetHashCode()*397) ^ this.Y.GetHashCode();
		    }
	    }
    }
}

