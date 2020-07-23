#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;


namespace Parquet.Thrift
{

   /// <summary>
   /// Decimal logical type annotation
   /// 
   /// To maintain forward-compatibility in v1, implementations using this logical
   /// type must also set scale and precision on the annotated SchemaElement.
   /// 
   /// Allowed for physical types: INT32, INT64, FIXED, and BINARY
   /// </summary>
   public partial class DecimalType : TBase
  {

    public int Scale { get; set; }

    public int Precision { get; set; }

    public DecimalType()
    {
    }

    public DecimalType(int scale, int precision) : this()
    {
      this.Scale = scale;
      this.Precision = precision;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_scale = false;
        bool isset_precision = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                Scale = await iprot.ReadI32Async(cancellationToken);
                isset_scale = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                Precision = await iprot.ReadI32Async(cancellationToken);
                isset_precision = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_scale)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_precision)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("DecimalType");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "scale";
        field.Type = TType.I32;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async(Scale, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "precision";
        field.Type = TType.I32;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async(Precision, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as DecimalType;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Scale, other.Scale)
        && System.Object.Equals(Precision, other.Precision);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Scale.GetHashCode();
        hashcode = (hashcode * 397) + Precision.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("DecimalType(");
      sb.Append(", Scale: ");
      sb.Append(Scale);
      sb.Append(", Precision: ");
      sb.Append(Precision);
      sb.Append(")");
      return sb.ToString();
    }
  }

}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
