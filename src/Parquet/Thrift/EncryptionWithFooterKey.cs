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

   public partial class EncryptionWithFooterKey : TBase
  {

    public EncryptionWithFooterKey()
    {
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
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
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
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
        var struc = new TStruct("EncryptionWithFooterKey");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
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
      var other = that as EncryptionWithFooterKey;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return true;
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("EncryptionWithFooterKey(");
      sb.Append(")");
      return sb.ToString();
    }
  }

}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
