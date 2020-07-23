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

   public partial class PageHeader : TBase
  {
    private int _crc;
    private DataPageHeader _data_page_header;
    private IndexPageHeader _index_page_header;
    private DictionaryPageHeader _dictionary_page_header;
    private DataPageHeaderV2 _data_page_header_v2;

    /// <summary>
    /// the type of the page: indicates which of the *_header fields is set *
    /// 
    /// <seealso cref="PageType"/>
    /// </summary>
    public PageType Type { get; set; }

    /// <summary>
    /// Uncompressed page size in bytes (not including this header) *
    /// </summary>
    public int Uncompressed_page_size { get; set; }

    /// <summary>
    /// Compressed (and potentially encrypted) page size in bytes, not including this header *
    /// </summary>
    public int Compressed_page_size { get; set; }

    /// <summary>
    /// The 32bit CRC for the page, to be be calculated as follows:
    /// - Using the standard CRC32 algorithm
    /// - On the data only, i.e. this header should not be included. 'Data'
    ///   hereby refers to the concatenation of the repetition levels, the
    ///   definition levels and the column value, in this exact order.
    /// - On the encoded versions of the repetition levels, definition levels and
    ///   column values
    /// - On the compressed versions of the repetition levels, definition levels
    ///   and column values where possible;
    ///   - For v1 data pages, the repetition levels, definition levels and column
    ///     values are always compressed together. If a compression scheme is
    ///     specified, the CRC shall be calculated on the compressed version of
    ///     this concatenation. If no compression scheme is specified, the CRC
    ///     shall be calculated on the uncompressed version of this concatenation.
    ///   - For v2 data pages, the repetition levels and definition levels are
    ///     handled separately from the data and are never compressed (only
    ///     encoded). If a compression scheme is specified, the CRC shall be
    ///     calculated on the concatenation of the uncompressed repetition levels,
    ///     uncompressed definition levels and the compressed column values.
    ///     If no compression scheme is specified, the CRC shall be calculated on
    ///     the uncompressed concatenation.
    /// If enabled, this allows for disabling checksumming in HDFS if only a few
    /// pages need to be read.
    /// 
    /// </summary>
    public int Crc
    {
      get
      {
        return _crc;
      }
      set
      {
        __isset.crc = true;
        this._crc = value;
      }
    }

    public DataPageHeader Data_page_header
    {
      get
      {
        return _data_page_header;
      }
      set
      {
        __isset.data_page_header = true;
        this._data_page_header = value;
      }
    }

    public IndexPageHeader Index_page_header
    {
      get
      {
        return _index_page_header;
      }
      set
      {
        __isset.index_page_header = true;
        this._index_page_header = value;
      }
    }

    public DictionaryPageHeader Dictionary_page_header
    {
      get
      {
        return _dictionary_page_header;
      }
      set
      {
        __isset.dictionary_page_header = true;
        this._dictionary_page_header = value;
      }
    }

    public DataPageHeaderV2 Data_page_header_v2
    {
      get
      {
        return _data_page_header_v2;
      }
      set
      {
        __isset.data_page_header_v2 = true;
        this._data_page_header_v2 = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool crc;
      public bool data_page_header;
      public bool index_page_header;
      public bool dictionary_page_header;
      public bool data_page_header_v2;
    }

    public PageHeader()
    {
    }

    public PageHeader(PageType type, int uncompressed_page_size, int compressed_page_size) : this()
    {
      this.Type = type;
      this.Uncompressed_page_size = uncompressed_page_size;
      this.Compressed_page_size = compressed_page_size;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_type = false;
        bool isset_uncompressed_page_size = false;
        bool isset_compressed_page_size = false;
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
                Type = (PageType)await iprot.ReadI32Async(cancellationToken);
                isset_type = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                Uncompressed_page_size = await iprot.ReadI32Async(cancellationToken);
                isset_uncompressed_page_size = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                Compressed_page_size = await iprot.ReadI32Async(cancellationToken);
                isset_compressed_page_size = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I32)
              {
                Crc = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Struct)
              {
                Data_page_header = new DataPageHeader();
                await Data_page_header.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.Struct)
              {
                Index_page_header = new IndexPageHeader();
                await Index_page_header.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.Struct)
              {
                Dictionary_page_header = new DictionaryPageHeader();
                await Dictionary_page_header.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.Struct)
              {
                Data_page_header_v2 = new DataPageHeaderV2();
                await Data_page_header_v2.ReadAsync(iprot, cancellationToken);
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
        if (!isset_type)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_uncompressed_page_size)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_compressed_page_size)
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
        var struc = new TStruct("PageHeader");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "type";
        field.Type = TType.I32;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async((int)Type, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "uncompressed_page_size";
        field.Type = TType.I32;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async(Uncompressed_page_size, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "compressed_page_size";
        field.Type = TType.I32;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async(Compressed_page_size, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if (__isset.crc)
        {
          field.Name = "crc";
          field.Type = TType.I32;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(Crc, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Data_page_header != null && __isset.data_page_header)
        {
          field.Name = "data_page_header";
          field.Type = TType.Struct;
          field.ID = 5;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Data_page_header.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Index_page_header != null && __isset.index_page_header)
        {
          field.Name = "index_page_header";
          field.Type = TType.Struct;
          field.ID = 6;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Index_page_header.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Dictionary_page_header != null && __isset.dictionary_page_header)
        {
          field.Name = "dictionary_page_header";
          field.Type = TType.Struct;
          field.ID = 7;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Dictionary_page_header.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Data_page_header_v2 != null && __isset.data_page_header_v2)
        {
          field.Name = "data_page_header_v2";
          field.Type = TType.Struct;
          field.ID = 8;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Data_page_header_v2.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
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
      var other = that as PageHeader;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Type, other.Type)
        && System.Object.Equals(Uncompressed_page_size, other.Uncompressed_page_size)
        && System.Object.Equals(Compressed_page_size, other.Compressed_page_size)
        && ((__isset.crc == other.__isset.crc) && ((!__isset.crc) || (System.Object.Equals(Crc, other.Crc))))
        && ((__isset.data_page_header == other.__isset.data_page_header) && ((!__isset.data_page_header) || (System.Object.Equals(Data_page_header, other.Data_page_header))))
        && ((__isset.index_page_header == other.__isset.index_page_header) && ((!__isset.index_page_header) || (System.Object.Equals(Index_page_header, other.Index_page_header))))
        && ((__isset.dictionary_page_header == other.__isset.dictionary_page_header) && ((!__isset.dictionary_page_header) || (System.Object.Equals(Dictionary_page_header, other.Dictionary_page_header))))
        && ((__isset.data_page_header_v2 == other.__isset.data_page_header_v2) && ((!__isset.data_page_header_v2) || (System.Object.Equals(Data_page_header_v2, other.Data_page_header_v2))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Type.GetHashCode();
        hashcode = (hashcode * 397) + Uncompressed_page_size.GetHashCode();
        hashcode = (hashcode * 397) + Compressed_page_size.GetHashCode();
        if(__isset.crc)
          hashcode = (hashcode * 397) + Crc.GetHashCode();
        if(__isset.data_page_header)
          hashcode = (hashcode * 397) + Data_page_header.GetHashCode();
        if(__isset.index_page_header)
          hashcode = (hashcode * 397) + Index_page_header.GetHashCode();
        if(__isset.dictionary_page_header)
          hashcode = (hashcode * 397) + Dictionary_page_header.GetHashCode();
        if(__isset.data_page_header_v2)
          hashcode = (hashcode * 397) + Data_page_header_v2.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("PageHeader(");
      sb.Append(", Type: ");
      sb.Append(Type);
      sb.Append(", Uncompressed_page_size: ");
      sb.Append(Uncompressed_page_size);
      sb.Append(", Compressed_page_size: ");
      sb.Append(Compressed_page_size);
      if (__isset.crc)
      {
        sb.Append(", Crc: ");
        sb.Append(Crc);
      }
      if (Data_page_header != null && __isset.data_page_header)
      {
        sb.Append(", Data_page_header: ");
        sb.Append(Data_page_header== null ? "<null>" : Data_page_header.ToString());
      }
      if (Index_page_header != null && __isset.index_page_header)
      {
        sb.Append(", Index_page_header: ");
        sb.Append(Index_page_header== null ? "<null>" : Index_page_header.ToString());
      }
      if (Dictionary_page_header != null && __isset.dictionary_page_header)
      {
        sb.Append(", Dictionary_page_header: ");
        sb.Append(Dictionary_page_header== null ? "<null>" : Dictionary_page_header.ToString());
      }
      if (Data_page_header_v2 != null && __isset.data_page_header_v2)
      {
        sb.Append(", Data_page_header_v2: ");
        sb.Append(Data_page_header_v2== null ? "<null>" : Data_page_header_v2.ToString());
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
