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

   /// <summary>
   /// Description for file metadata
   /// </summary>
   public partial class FileMetaData : TBase
  {
    private List<KeyValue> _key_value_metadata;
    private string _created_by;
    private List<ColumnOrder> _column_orders;
    private EncryptionAlgorithm _encryption_algorithm;
    private byte[] _footer_signing_key_metadata;

    /// <summary>
    /// Version of this file *
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// Parquet schema for this file.  This schema contains metadata for all the columns.
    /// The schema is represented as a tree with a single root.  The nodes of the tree
    /// are flattened to a list by doing a depth-first traversal.
    /// The column metadata contains the path in the schema for that column which can be
    /// used to map columns to nodes in the schema.
    /// The first element is the root *
    /// </summary>
    public List<SchemaElement> Schema { get; set; }

    /// <summary>
    /// Number of rows in this file *
    /// </summary>
    public long Num_rows { get; set; }

    /// <summary>
    /// Row groups in this file *
    /// </summary>
    public List<RowGroup> Row_groups { get; set; }

    /// <summary>
    /// Optional key/value metadata *
    /// </summary>
    public List<KeyValue> Key_value_metadata
    {
      get
      {
        return _key_value_metadata;
      }
      set
      {
        __isset.key_value_metadata = true;
        this._key_value_metadata = value;
      }
    }

    /// <summary>
    /// String for application that wrote this file.  This should be in the format
    /// &lt;Application> version &lt;App Version&gt; (build &lt;App Build Hash>).
    /// e.g. impala version 1.0 (build 6cf94d29b2b7115df4de2c06e2ab4326d721eb55)
    /// 
    /// </summary>
    public string Created_by
    {
      get
      {
        return _created_by;
      }
      set
      {
        __isset.created_by = true;
        this._created_by = value;
      }
    }

    /// <summary>
    /// Sort order used for the min_value and max_value fields of each column in
    /// this file. Sort orders are listed in the order matching the columns in the
    /// schema. The indexes are not necessary the same though, because only leaf
    /// nodes of the schema are represented in the list of sort orders.
    /// 
    /// Without column_orders, the meaning of the min_value and max_value fields is
    /// undefined. To ensure well-defined behaviour, if min_value and max_value are
    /// written to a Parquet file, column_orders must be written as well.
    /// 
    /// The obsolete min and max fields are always sorted by signed comparison
    /// regardless of column_orders.
    /// </summary>
    public List<ColumnOrder> Column_orders
    {
      get
      {
        return _column_orders;
      }
      set
      {
        __isset.column_orders = true;
        this._column_orders = value;
      }
    }

    /// <summary>
    /// Encryption algorithm. This field is set only in encrypted files
    /// with plaintext footer. Files with encrypted footer store algorithm id
    /// in FileCryptoMetaData structure.
    /// </summary>
    public EncryptionAlgorithm Encryption_algorithm
    {
      get
      {
        return _encryption_algorithm;
      }
      set
      {
        __isset.encryption_algorithm = true;
        this._encryption_algorithm = value;
      }
    }

    /// <summary>
    /// Retrieval metadata of key used for signing the footer.
    /// Used only in encrypted files with plaintext footer.
    /// </summary>
    public byte[] Footer_signing_key_metadata
    {
      get
      {
        return _footer_signing_key_metadata;
      }
      set
      {
        __isset.footer_signing_key_metadata = true;
        this._footer_signing_key_metadata = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool key_value_metadata;
      public bool created_by;
      public bool column_orders;
      public bool encryption_algorithm;
      public bool footer_signing_key_metadata;
    }

    public FileMetaData()
    {
    }

    public FileMetaData(int version, List<SchemaElement> schema, long num_rows, List<RowGroup> row_groups) : this()
    {
      this.Version = version;
      this.Schema = schema;
      this.Num_rows = num_rows;
      this.Row_groups = row_groups;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_version = false;
        bool isset_schema = false;
        bool isset_num_rows = false;
        bool isset_row_groups = false;
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
                Version = await iprot.ReadI32Async(cancellationToken);
                isset_version = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  TList _list48 = await iprot.ReadListBeginAsync(cancellationToken);
                  Schema = new List<SchemaElement>(_list48.Count);
                  for(int _i49 = 0; _i49 < _list48.Count; ++_i49)
                  {
                    SchemaElement _elem50;
                    _elem50 = new SchemaElement();
                    await _elem50.ReadAsync(iprot, cancellationToken);
                    Schema.Add(_elem50);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_schema = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                Num_rows = await iprot.ReadI64Async(cancellationToken);
                isset_num_rows = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.List)
              {
                {
                  TList _list51 = await iprot.ReadListBeginAsync(cancellationToken);
                  Row_groups = new List<RowGroup>(_list51.Count);
                  for(int _i52 = 0; _i52 < _list51.Count; ++_i52)
                  {
                    RowGroup _elem53;
                    _elem53 = new RowGroup();
                    await _elem53.ReadAsync(iprot, cancellationToken);
                    Row_groups.Add(_elem53);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_row_groups = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.List)
              {
                {
                  TList _list54 = await iprot.ReadListBeginAsync(cancellationToken);
                  Key_value_metadata = new List<KeyValue>(_list54.Count);
                  for(int _i55 = 0; _i55 < _list54.Count; ++_i55)
                  {
                    KeyValue _elem56;
                    _elem56 = new KeyValue();
                    await _elem56.ReadAsync(iprot, cancellationToken);
                    Key_value_metadata.Add(_elem56);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                Created_by = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.List)
              {
                {
                  TList _list57 = await iprot.ReadListBeginAsync(cancellationToken);
                  Column_orders = new List<ColumnOrder>(_list57.Count);
                  for(int _i58 = 0; _i58 < _list57.Count; ++_i58)
                  {
                    ColumnOrder _elem59;
                    _elem59 = new ColumnOrder();
                    await _elem59.ReadAsync(iprot, cancellationToken);
                    Column_orders.Add(_elem59);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.Struct)
              {
                Encryption_algorithm = new EncryptionAlgorithm();
                await Encryption_algorithm.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.String)
              {
                Footer_signing_key_metadata = await iprot.ReadBinaryAsync(cancellationToken);
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
        if (!isset_version)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_schema)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_num_rows)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_row_groups)
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
        var struc = new TStruct("FileMetaData");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "version";
        field.Type = TType.I32;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async(Version, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "schema";
        field.Type = TType.List;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Struct, Schema.Count), cancellationToken);
          foreach (SchemaElement _iter60 in Schema)
          {
            await _iter60.WriteAsync(oprot, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "num_rows";
        field.Type = TType.I64;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(Num_rows, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "row_groups";
        field.Type = TType.List;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Struct, Row_groups.Count), cancellationToken);
          foreach (RowGroup _iter61 in Row_groups)
          {
            await _iter61.WriteAsync(oprot, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        if (Key_value_metadata != null && __isset.key_value_metadata)
        {
          field.Name = "key_value_metadata";
          field.Type = TType.List;
          field.ID = 5;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Key_value_metadata.Count), cancellationToken);
            foreach (KeyValue _iter62 in Key_value_metadata)
            {
              await _iter62.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Created_by != null && __isset.created_by)
        {
          field.Name = "created_by";
          field.Type = TType.String;
          field.ID = 6;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Created_by, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Column_orders != null && __isset.column_orders)
        {
          field.Name = "column_orders";
          field.Type = TType.List;
          field.ID = 7;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Column_orders.Count), cancellationToken);
            foreach (ColumnOrder _iter63 in Column_orders)
            {
              await _iter63.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Encryption_algorithm != null && __isset.encryption_algorithm)
        {
          field.Name = "encryption_algorithm";
          field.Type = TType.Struct;
          field.ID = 8;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Encryption_algorithm.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Footer_signing_key_metadata != null && __isset.footer_signing_key_metadata)
        {
          field.Name = "footer_signing_key_metadata";
          field.Type = TType.String;
          field.ID = 9;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(Footer_signing_key_metadata, cancellationToken);
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
      var other = that as FileMetaData;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Version, other.Version)
        && TCollections.Equals(Schema, other.Schema)
        && System.Object.Equals(Num_rows, other.Num_rows)
        && TCollections.Equals(Row_groups, other.Row_groups)
        && ((__isset.key_value_metadata == other.__isset.key_value_metadata) && ((!__isset.key_value_metadata) || (TCollections.Equals(Key_value_metadata, other.Key_value_metadata))))
        && ((__isset.created_by == other.__isset.created_by) && ((!__isset.created_by) || (System.Object.Equals(Created_by, other.Created_by))))
        && ((__isset.column_orders == other.__isset.column_orders) && ((!__isset.column_orders) || (TCollections.Equals(Column_orders, other.Column_orders))))
        && ((__isset.encryption_algorithm == other.__isset.encryption_algorithm) && ((!__isset.encryption_algorithm) || (System.Object.Equals(Encryption_algorithm, other.Encryption_algorithm))))
        && ((__isset.footer_signing_key_metadata == other.__isset.footer_signing_key_metadata) && ((!__isset.footer_signing_key_metadata) || (TCollections.Equals(Footer_signing_key_metadata, other.Footer_signing_key_metadata))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Version.GetHashCode();
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Schema);
        hashcode = (hashcode * 397) + Num_rows.GetHashCode();
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Row_groups);
        if(__isset.key_value_metadata)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Key_value_metadata);
        if(__isset.created_by)
          hashcode = (hashcode * 397) + Created_by.GetHashCode();
        if(__isset.column_orders)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Column_orders);
        if(__isset.encryption_algorithm)
          hashcode = (hashcode * 397) + Encryption_algorithm.GetHashCode();
        if(__isset.footer_signing_key_metadata)
          hashcode = (hashcode * 397) + Footer_signing_key_metadata.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("FileMetaData(");
      sb.Append(", Version: ");
      sb.Append(Version);
      sb.Append(", Schema: ");
      sb.Append(Schema);
      sb.Append(", Num_rows: ");
      sb.Append(Num_rows);
      sb.Append(", Row_groups: ");
      sb.Append(Row_groups);
      if (Key_value_metadata != null && __isset.key_value_metadata)
      {
        sb.Append(", Key_value_metadata: ");
        sb.Append(Key_value_metadata);
      }
      if (Created_by != null && __isset.created_by)
      {
        sb.Append(", Created_by: ");
        sb.Append(Created_by);
      }
      if (Column_orders != null && __isset.column_orders)
      {
        sb.Append(", Column_orders: ");
        sb.Append(Column_orders);
      }
      if (Encryption_algorithm != null && __isset.encryption_algorithm)
      {
        sb.Append(", Encryption_algorithm: ");
        sb.Append(Encryption_algorithm== null ? "<null>" : Encryption_algorithm.ToString());
      }
      if (Footer_signing_key_metadata != null && __isset.footer_signing_key_metadata)
      {
        sb.Append(", Footer_signing_key_metadata: ");
        sb.Append(Footer_signing_key_metadata);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
