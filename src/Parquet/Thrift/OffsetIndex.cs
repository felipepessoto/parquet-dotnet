#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;


namespace Parquet.Thrift
{

   public partial class OffsetIndex : TBase
  {

      /// <summary>
      /// PageLocations, ordered by increasing PageLocation.offset. It is required
      /// that page_locations[i].first_row_index &lt; page_locations[i+1].first_row_index.
      /// </summary>
      public List<PageLocation> Page_locations { get; set; }

    public OffsetIndex()
    {
    }

    public OffsetIndex(List<PageLocation> page_locations) : this()
    {
      this.Page_locations = page_locations;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_page_locations = false;
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
              if (field.Type == TType.List)
              {
                {
                  TList _list28 = await iprot.ReadListBeginAsync(cancellationToken);
                  Page_locations = new List<PageLocation>(_list28.Count);
                  for(int _i29 = 0; _i29 < _list28.Count; ++_i29)
                  {
                    PageLocation _elem30;
                    _elem30 = new PageLocation();
                    await _elem30.ReadAsync(iprot, cancellationToken);
                    Page_locations.Add(_elem30);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_page_locations = true;
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
        if (!isset_page_locations)
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
        var struc = new TStruct("OffsetIndex");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "page_locations";
        field.Type = TType.List;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Struct, Page_locations.Count), cancellationToken);
          foreach (PageLocation _iter31 in Page_locations)
          {
            await _iter31.WriteAsync(oprot, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
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
      var other = that as OffsetIndex;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return TCollections.Equals(Page_locations, other.Page_locations);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Page_locations);
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("OffsetIndex(");
      sb.Append(", Page_locations: ");
      sb.Append(Page_locations);
      sb.Append(")");
      return sb.ToString();
    }
  }

}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
