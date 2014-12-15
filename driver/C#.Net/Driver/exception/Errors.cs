namespace SequoiaDB
{
    class Errors
    {
        public enum errors : int
        {
            SDB_IO                           = -1,
            SDB_OOM                          = -2,
            SDB_PERM                         = -3,
            SDB_FNE                          = -4,
            SDB_FE                           = -5,
            SDB_INVALIDARG                   = -6,
            SDB_INVALIDSIZE                  = -7,
            SDB_INTERRUPT                    = -8,
            SDB_EOF                          = -9,
            SDB_SYS                          = -10,
            SDB_NOSPC                        = -11,
            SDB_EDU_INVAL_STATUS             = -12,
            SDB_TIMEOUT                      = -13,
            SDB_QUIESCED                     = -14,
            SDB_NETWORK                      = -15,
            SDB_NETWORK_CLOSE                = -16,
            SDB_DATABASE_DOWN                = -17,
            SDB_APP_FORCED                   = -18,
            SDB_INVALIDPATH                  = -19,
            SDB_INVALID_FILE_TYPE            = -20,
            SDB_DMS_NOSPC                    = -21,
            SDB_DMS_EXIST                    = -22,
            SDB_DMS_NOTEXIST                 = -23,
            SDB_DMS_RECORD_TOO_BIG           = -24,
            SDB_DMS_RECORD_NOTEXIST          = -25,
            SDB_DMS_OVF_EXIST                = -26,
            SDB_DMS_RECORD_INVALID           = -27,
            SDB_DMS_SU_NEED_REORG            = -28,
            SDB_DMS_EOC                      = -29,
            SDB_DMS_CONTEXT_IS_OPEN          = -30,
            SDB_DMS_CONTEXT_IS_CLOSE         = -31,
            SDB_OPTION_NOT_SUPPORT           = -32,
            SDB_DMS_CS_EXIST                 = -33,
            SDB_DMS_CS_NOTEXIST              = -34,
            SDB_DMS_INVALID_SU               = -35,
            SDB_RTN_CONTEXT_NOTEXIST         = -36,
            SDB_IXM_MULTIPLE_ARRAY           = -37,
            SDB_IXM_DUP_KEY                  = -38,
            SDB_IXM_KEY_TOO_LARGE            = -39,
            SDB_IXM_NOSPC                    = -40,
            SDB_IXM_KEY_NOTEXIST             = -41,
            SDB_DMS_MAX_INDEX                = -42,
            SDB_DMS_INIT_INDEX               = -43,
            SDB_DMS_COL_DROPPED              = -44,
            SDB_IXM_IDENTICAL_KEY            = -45,
            SDB_IXM_EXIST                    = -46,
            SDB_IXM_NOTEXIST                 = -47,
            SDB_IXM_UNEXPECTED_STATUS        = -48,
            SDB_IXM_EOC                      = -49,
            SDB_IXM_DEDUP_BUF_MAX            = -50,
            SDB_RTN_INVALID_PREDICATES       = -51,
            SDB_RTN_INDEX_NOTEXIST           = -52,
            SDB_RTN_INVALID_HINT             = -53,
            SDB_DMS_NO_MORE_TEMP             = -54,
            SDB_DMS_SU_OUTRANGE              = -55,
            SDB_IXM_DROP_ID                  = -56,
            SDB_DPS_LOG_NOT_IN_BUF           = -57,
            SDB_DPS_LOG_NOT_IN_FILE          = -58,
            SDB_PMD_RG_NOT_EXIST             = -59,
            SDB_PMD_RG_EXIST                 = -60,
            SDB_INVALID_REQID                = -61,
            SDB_PMD_SESSION_NOT_EXIST        = -62,
            SDB_PMD_FORCE_SYSTEM_EDU         = -63,
            SDB_NOT_CONNECTED                = -64,
            SDB_UNEXPECTED_RESULT            = -65,
            SDB_CORRUPTED_RECORD             = -66,
            SDB_BACKUP_HAS_ALREADY_START     = -67,
            SDB_BACKUP_NOT_COMPLETE          = -68,
            SDB_RTN_IN_BACKUP                = -69,
            SDB_BAR_DAMAGED_BK_FILE          = -70,
            SDB_RTN_NO_PRIMARY_FOUND         = -71,
            SDB_CAT_NODE_NOT_FOUND           = -72,
            SDB_PMD_HELP_ONLY                = -73,
            SDB_PMD_CON_INVALID_STATE        = -74,
            SDB_CLT_INVALID_HANDLE           = -75,
            SDB_CLT_OBJ_NOT_EXIST            = -76,
            SDB_NET_ALREADY_LISTENED         = -77,
            SDB_NET_CANNOT_LISTEN            = -78,
            SDB_NET_CANNOT_CONNECT           = -79,
            SDB_NET_NOT_CONNECT              = -80,
            SDB_NET_SEND_ERR                 = -81,
            SDB_NET_TIMER_ID_NOT_FOUND       = -82,
            SDB_NET_ROUTE_NOT_FOUND          = -83,
            SDB_NET_BROKEN_MSG               = -84,
            SDB_NET_INVALID_HANDLE           = -85,
            SDB_DMS_INVALID_REORG_FILE       = -86,
            SDB_DMS_REORG_FILE_READONLY      = -87,
            SDB_DMS_INVALID_COLLECTION_S     = -88,
            SDB_DMS_NOT_IN_REORG             = -89,
            SDB_REPL_GROUP_NOT_ACTIVE        = -90,
            SDB_REPL_INVALID_GROUP_MEMBER    = -91,
            SDB_DMS_INCOMPATIBLE_MODE        = -92,
            SDB_DMS_INCOMPATIBLE_VERSION     = -93,
            SDB_REPL_LOCAL_G_V_EXPIRED       = -94,
            SDB_DMS_INVALID_PAGESIZE         = -95,
            SDB_REPL_REMOTE_G_V_EXPIRED      = -96,
            SDB_CLS_VOTE_FAILED              = -97,
            SDB_DPS_CORRUPTED_LOG            = -98,
            SDB_DPS_LSN_OUTOFRANGE           = -99,
            SDB_UNKNOWN_MESSAGE              = -100,
            SDB_NET_UPDATE_EXISTING_NODE     = -101,
            SDB_CLS_UNKNOW_MSG               = -102,
            SDB_CLS_EMPTY_HEAP               = -103,
            SDB_CLS_NOT_PRIMARY              = -104,
            SDB_CLS_NODE_NOT_ENOUGH          = -105,
            SDB_CLS_NO_CATALOG_INFO          = -106,
            SDB_CLS_DATA_NODE_CAT_VER_OLD    = -107,
            SDB_CLS_COORD_NODE_CAT_VER_OLD   = -108,
            SDB_CLS_INVALID_GROUP_NUM        = -109,
            SDB_CLS_SYNC_FAILED              = -110,
            SDB_CLS_REPLAY_LOG_FAILED        = -111,
            SDB_REST_EHS                     = -112,
            SDB_CLS_CONSULT_FAILED           = -113,
            SDB_DPS_MOVE_FAILED              = -114,
            SDB_DMS_CORRUPTED_SME            = -115,
            SDB_APP_INTERRUPT                = -116,
            SDB_APP_DISCONNECT               = -117,
            SDB_OSS_CCE                      = -118,
            SDB_COORD_QUERY_FAILED           = -119,
            SDB_CLS_BUFFER_FULL              = -120,
            SDB_RTN_SUBCONTEXT_CONFLICT      = -121,
            SDB_COORD_QUERY_EOC              = -122,
            SDB_DPS_FILE_SIZE_NOT_SAME       = -123,
            SDB_DPS_FILE_NOT_RECOGNISE       = -124,
            SDB_OSS_NORES                    = -125,
            SDB_DPS_INVALID_LSN              = -126,
            SDB_OSS_NPIPE_DATA_TOO_BIG       = -127,
            SDB_CAT_AUTH_FAILED              = -128,
            SDB_CLS_FULL_SYNC                = -129,
            SDB_CAT_ASSIGN_NODE_FAILED       = -130,
            SDB_PHP_DRIVER_INTERNAL_ERROR    = -131,
            SDB_COORD_SEND_MSG_FAILED        = -132,
            SDB_CAT_NO_NODEGROUP_INFO        = -133,
            SDB_COORD_REMOTE_DISC            = -134,
            SDB_CAT_NO_MATCH_CATALOG         = -135,
            SDB_CLS_UPDATE_CAT_FAILED        = -136,
            SDB_COORD_UNKNOWN_OP_REQ         = -137,
            SDB_COOR_NO_NODEGROUP_INFO       = -138,
            SDB_DMS_CORRUPTED_EXTENT         = -139,
            SDBCM_FAIL                       = -140,
            SDBCM_STOP_PART                  = -141,
            SDBCM_SVC_STARTING               = -142,
            SDBCM_SVC_STARTED                = -143,
            SDBCM_SVC_RESTARTING             = -144,
            SDBCM_NODE_EXISTED               = -145,
            SDBCM_NODE_NOTEXISTED            = -146,
            SDB_LOCK_FAILED                  = -147,
            SDB_DMS_STATE_NOT_COMPATIBLE     = -148,
            SDB_REBUILD_HAS_ALREADY_START    = -149,
            SDB_RTN_IN_REBUILD               = -150,
            SDB_RTN_COORD_CACHE_EMPTY        = -151,
            SDB_SPT_EVAL_FAIL                = -152,
            SDB_CAT_GRP_EXIST                = -153,
            SDB_CLS_GRP_NOT_EXIST            = -154,
            SDB_CLS_NODE_NOT_EXIST           = -155,
            SDB_CM_RUN_NODE_FAILED           = -156,
            SDB_CM_CONFIG_CONFLICTS          = -157,
            SDB_CLS_EMPTY_GROUP              = -158,
            SDB_RTN_COORD_ONLY               = -159,
            SDB_CM_OP_NODE_FAILED            = -160,
            SDB_RTN_MUTEX_JOB_EXIST          = -161,
            SDB_RTN_JOB_NOT_EXIST            = -162,
            SDB_CAT_CORRUPTION               = -163,
            SDB_IXM_DROP_SHARD               = -164,
            SDB_RTN_CMD_NO_NODE_AUTH         = -165,
            SDB_RTN_CMD_NO_SERVICE_AUTH      = -166,
            SDB_CLS_NO_GROUP_INFO            = -167,
            SDB_CLS_GROUP_NAME_CONFLICT      = -168,
            SDB_COLLECTION_NOTSHARD          = -169,
            SDB_INVALID_SHARDINGKEY          = -170,
            SDB_TASK_EXIST                   = -171,
            SDB_CL_NOT_EXIST_ON_GROUP        = -172,
            SDB_CAT_TASK_NOTFOUND            = -173,
            SDB_MULTI_SHARDING_KEY           = -174,
            SDB_CLS_MUTEX_TASK_EXIST         = -175,
            SDB_CLS_BAD_SPLIT_KEY            = -176,
            SDB_SHARD_KEY_NOT_IN_UNIQUE_KEY  = -177,
            SDB_UPDATE_SHARD_KEY             = -178,
            SDB_AUTH_AUTHORITY_FORBIDDEN     = -179,
            SDB_CAT_NO_ADDR_LIST             = -180,
            SDB_CURRENT_RECORD_DELETED       = -181,
            SDB_QGM_MATCH_NONE               = -182,
            SDB_IXM_REORG_DONE               = -183,
            SDB_RTN_DUPLICATE_FIELDNAME      = -184,
            SDB_QGM_MAX_NUM_RECORD           = -185,
            SDB_QGM_MERGE_JOIN_EQONLY        = -186,
            SDB_PD_TRACE_IS_STARTED          = -187,
            SDB_PD_TRACE_HAS_NO_BUFFER       = -188,
            SDB_PD_TRACE_FILE_INVALID        = -189,
            SDB_DPS_TRANS_LOCK_INCOMPATIBLE  = -190,
            SDB_DPS_TRANS_DOING_ROLLBACK     = -191,
            SDB_MIG_IMP_BAD_RECORD           = -192,
            SDB_QGM_REPEAT_VAR_NAME          = -193,
            SDB_QGM_AMBIGUOUS_FIELD          = -194,
            SDB_SQL_SYNTAX_ERROR             = -195,
            SDB_DPS_TRANS_NO_TRANS           = -196,
            SDB_DPS_TRANS_APPEND_TO_WAIT     = -197,
            SDB_DMS_DELETING                 = -198,
            SDB_DMS_INVALID_INDEXCB          = -199,
            SDB_COORD_RECREATE_CATALOG       = -200,
            SDB_UTIL_PARSE_JSON_INVALID      = -201,
            SDB_UTIL_PARSE_CSV_INVALID       = -202,
            SDB_DPS_LOG_FILE_OUT_OF_SIZE     = -203,
            SDB_CATA_RM_NODE_FORBIDDEN       = -204,
            SDB_CATA_FAILED_TO_CLEANUP       = -205,
            SDB_CATA_RM_CATA_FORBIDDEN       = -206,
            SDB_CAT_GRP_NOT_EXIST            = -207,
            SDB_CAT_RM_GRP_FORBIDDEN         = -208,
            SDB_MIG_END_OF_QUEUE             = -209,
            SDB_COORD_SPLIT_NO_SHDIDX        = -210,
            SDB_FIELD_NOT_EXIST              = -211,
            SDB_TOO_MANY_TRACE_BP            = -212,
            SDB_BUSY_PREFETCHER              = -213,
            SDB_CAT_DOMAIN_NOT_EXIST         = -214,
            SDB_CAT_DOMAIN_EXIST             = -215,
            SDB_CAT_GROUP_NOT_IN_DOMAIN      = -216,
            SDB_CLS_SHARDING_NOT_HASH        = -217,
            SDB_CLS_SPLIT_PERCENT_LOWER      = -218,
            SDB_TASK_ALREADY_FINISHED        = -219,
            SDB_COLLECTION_LOAD              = -220,
            SDB_LOAD_ROLLBACK                = -221,
            SDB_INVALID_ROUTEID              = -222,
            SDB_DUPLICATED_SERVICE           = -223,
            SDB_UTIL_NOT_FIND_FIELD          = -224,
            SDB_UTIL_CSV_FIELD_END           = -225,
            SDB_MIG_UNKNOW_FILE_TYPE         = -226,
            SDB_RTN_EXPORTCONF_NOT_COMPLETE  = -227,
            SDB_CLS_NOTP_AND_NODATA          = -228,
            SDB_DMS_SECRETVALUE_NOT_SAME     = -229,
            SDB_PMD_VERSION_ONLY             = -230,
            SDB_SDB_HELP_ONLY                = -231,
            SDB_SDB_VERSION_ONLY             = -232,
            SDB_FMP_FUNC_NOT_EXIST           = -233,
            SDB_ILL_RM_SUB_CL                = -234,
            SDB_RELINK_SUB_CL                = -235,
            SDB_INVALID_MAIN_CL              = -236,
            SDB_BOUND_CONFLICT               = -237,
            SDB_BOUND_INVALID                = -238,
            SDB_HIT_HIGH_WATERMARK           = -239,
            SDB_BAR_BACKUP_EXIST             = -240,
            SDB_BAR_BACKUP_NOTEXIST          = -241,
            SDB_INVALID_SUB_CL               = -242,
            SDB_TASK_HAS_CANCELED            = -243,
            SDB_INVALID_MAIN_CL_TYPE         = -244,
            SDB_NO_SHARDINGKEY               = -245,
            SDB_MAIN_CL_OP_ERR               = -246,
            SDB_IXM_REDEF                    = -247,
            SDB_DMS_CS_DELETING              = -248,
            SDB_DMS_REACHED_MAX_NODES        = -249,
            SDB_CLS_NODE_BSFAULT             = -250,
            SDB_CLS_NODE_INFO_EXPIRED        = -251,
            SDB_CLS_WAIT_SYNC_FAILED         = -252,
            SDB_DPS_TRANS_DIABLED            = -253,
            SDB_DRIVER_DS_RUNOUT             = -254,
            SDB_TOO_MANY_OPEN_FD             = -255,
            SDB_DOMAIN_IS_OCCUPIED           = -256,
            SDB_REST_RECV_SIZE               = -257,
            SDB_DRIVER_BSON_ERROR            = -258,
            SDB_OUT_OF_BOUND                 = -259,
            SDB_REST_COMMON_UNKNOWN          = -260,
            SDB_BUT_FAILED_ON_DATA           = -261,
            SDB_CAT_NO_GROUP_IN_DOMAIN       = -262,
            SDB_OM_PASSWD_CHANGE_SUGGUEST    = -263,
            SDB_COORD_NOT_ALL_DONE           = -264,
            SDB_OMA_DIFF_VER_AGT_IS_RUNNING  = -265,
            SDB_OM_TASK_NOT_EXIST            = -266,
            SDB_OM_TASK_ROLLBACK             = -267,
            SDB_LOB_SEQUENCE_NOT_EXIST       = -268,
            SDB_LOB_IS_NOT_AVAILABLE         = -269,
            SDB_MIG_DATA_NON_UTF             = -270,
            SDB_OMA_TASK_FAIL                = -271,
            SDB_LOB_NOT_OPEN                 = -272,
            SDB_LOB_HAS_OPEN                 = -273
        };

        public static readonly string[] descriptions = {
                                                    "IO Exception",
                                                    "Out of Memory",
                                                    "Permission Error",
                                                    "File Not Exist",
                                                    "File Exist",
                                                    "Invalid Argument",
                                                    "Invalid size",
                                                    "Interrupt",
                                                    "Hit end of file",
                                                    "System error",
                                                    "No space is left on disk",
                                                    "EDU status is not valid",
                                                    "Timeout error",
                                                    "Database is quiesced",
                                                    "Network error",
                                                    "Network is closed from remote",
                                                    "Database is in shutdown status",
                                                    "Application is forced",
                                                    "Given path is not valid",
                                                    "Unexpected file type specified",
                                                    "There's no space for DMS",
                                                    "Collection already exists",
                                                    "Collection does not exist",
                                                    "User record is too large",
                                                    "Record does not exist",
                                                    "Remote overflow record exists",
                                                    "Invalid record",
                                                    "Storage unit need reorg",
                                                    "End of collection",
                                                    "Context is already opened",
                                                    "Context is closed",
                                                    "Option is not supported yet",
                                                    "Collection space already exists",
                                                    "Collection space does not exist",
                                                    "Storage unit file is invalid",
                                                    "Context does not exist",
                                                    "More than one fields are array type",
                                                    "Duplicate key exist",
                                                    "Index key is too large",
                                                    "No space can be found for index extent",
                                                    "Index key does not exist",
                                                    "Hit max number of index",
                                                    "Failed to initialize index",
                                                    "Collection is dropped",
                                                    "Two records get same key and rid",
                                                    "Duplicate index name",
                                                    "Index name does not exist",
                                                    "Unexpected index flag",
                                                    "Hit end of index",
                                                    "Hit the max of dedup buffer",
                                                    "Invalid predicates",
                                                    "Index does not exist",
                                                    "Invalid hint",
                                                    "No more temp collections are avaliable",
                                                    "Exceed max number of storage unit",
                                                    "$id index can't be dropped",
                                                    "Log was not found in log buf",
                                                    "Log was not found in log file",
                                                    "Replication group does not exist",
                                                    "Replication group exists",
                                                    "Invalid request id is received",
                                                    "Session ID does not exist",
                                                    "System EDU cannot be forced",
                                                    "Database is not connected",
                                                    "Unexpected result received",
                                                    "Corrupted record",
                                                    "Backup has already been started",
                                                    "Backup is not completed",
                                                    "Backup is in progress",
                                                    "Backup is corrupted",
                                                    "No primary node was found",
                                                    "Requested node does not exist",
                                                    "Engine help argument is specified",
                                                    "Invalid connection state",
                                                    "Invalid handle",
                                                    "Object does not exist",
                                                    "Listening port is already occupied",
                                                    "Unable to listen the specified address",
                                                    "Unable to connect to the specified address",
                                                    "Connection does not exist",
                                                    "Failed to send",
                                                    "Timer does not exist",
                                                    "Route info does not exist",
                                                    "Broken msg",
                                                    "Invalid net handle",
                                                    "Invalid reorg file",
                                                    "Reorg file is in read only mode",
                                                    "Collection status is not valid",
                                                    "Collection is not in reorg state",
                                                    "Replication group is not activated",
                                                    "Node does not belong to the group",
                                                    "Collection status is not compatible",
                                                    "Incompatible version for storage unit",
                                                    "Version is expired for local group",
                                                    "Invalid page size",
                                                    "Version is expired for remote group",
                                                    "Failed to vote for primary",
                                                    "Log record is corrupted",
                                                    "LSN is out of boundary",
                                                    "Unknown mesage is received",
                                                    "Updated information is same as old one",
                                                    "Unknown message",
                                                    "Empty heap",
                                                    "Node is not primary",
                                                    "Not enough number of data nodes",
                                                    "Catalog information does not exist on data node",
                                                    "Catalog version is expired on data node",
                                                    "Catalog version is expired on coordinator node",
                                                    "Exceeds the max group size",
                                                    "Failed to sync log",
                                                    "Failed to replay log",
                                                    "Invalid HTTP header",
                                                    "Failed to negotiate",
                                                    "Failed to change DPS metadata",
                                                    "SME is corrupted",
                                                    "Application is interrupted",
                                                    "Application is disconnected",
                                                    "Character encoding errors",
                                                    "Failed to query on coord node",
                                                    "Buffer array is full",
                                                    "Sub context is conflict",
                                                    "EOC message is received by coordinator node",
                                                    "Size of DPS files are not the same",
                                                    "Invalid DPS log file",
                                                    "No resource is avaliable",
                                                    "Invalid LSN",
                                                    "Pipe buffer size is too small",
                                                    "Catalog authentication failed",
                                                    "Full sync is in progress",
                                                    "Failed to assign data node from coordinator node",
                                                    "PHP driver internal error",
                                                    "Failed to send the message",
                                                    "Unable to find the group information on catalog",
                                                    "Remote-node is disconnected",
                                                    "Unable to find the catalog information",
                                                    "Failed to update catalog",
                                                    "Unknown request operation code",
                                                    "Group information cannot be found on coordinator node",
                                                    "DMS extent is corrupted",
                                                    "Remote cluster manager failed",
                                                    "Remote database services have been stopped",
                                                    "Service is starting",
                                                    "Service has been started",
                                                    "Service is restarting",
                                                    "Node already exists",
                                                    "Node does not exist",
                                                    "Unable to lock",
                                                    "DMS state is not compatible with current command",
                                                    "Database rebuild is already started",
                                                    "Database rebuild is in progress",
                                                    "Cache is empty on coordinator node",
                                                    "Evalution failed with error",
                                                    "Group already exist",
                                                    "Group does not exist",
                                                    "Node does not exist",
                                                    "Failed to start the node",
                                                    "Invalid node configuration",
                                                    "Group is empty",
                                                    "The operation is for coord node only",
                                                    "Failed to operate on node only",
                                                    "The mutex job already exist",
                                                    "The specified job does not exist",
                                                    "The catalog information is corrupted",
                                                    "$shard index can't be dropped",
                                                    "The command can't be run in the node",
                                                    "The command can't be run in the serice plane",
                                                    "The group info not exist",
                                                    "Group name is conflict",
                                                    "The collection is not sharded",
                                                    "The record does not contains valid sharding key",
                                                    "A task that already exists does not compatible with the new task",
                                                    "The collection does not exists on the specified group",
                                                    "The specified task does not exist",
                                                    "The record contains more than one sharding key",
                                                    "The mutex task already exist",
                                                    "The split key is not valid or not in the source group",
                                                    "The unique index must include all fields in sharding key",
                                                    "Sharding key cannot be updated",
                                                    "Authority is forbidden",
                                                    "There is no catalog address specified by user",
                                                    "Current record has been removed",
                                                    "No records can be matched for the search condition",
                                                    "Index page is reorged and the pos got different lchild",
                                                    "Duplicate field name exists in the record",
                                                    "Too many records to be inserted at once",
                                                    "Sort-Merge Join only supports equal predicates",
                                                    "Trace is already started",
                                                    "Trace buffer does not exist",
                                                    "Trace file is not valid",
                                                    "Incompatible lock",
                                                    "Rollback operation is in progress",
                                                    "Invalid record is found during import",
                                                    "Repeated variable name",
                                                    "Column name is ambiguous",
                                                    "SQL syntax error",
                                                    "Invalid transactional operation",
                                                    "Append to lock-wait-queue",
                                                    "Record is deleted",
                                                    "Index is dropped or invalid",
                                                    "Unable to create new catalog when there's already one exists",
                                                    "Failed to parse JSON file",
                                                    "Failed to parse CSV file",
                                                    "Log file size is too large",
                                                    "Unable to remove the last node in a group",
                                                    "Unable to clean up catalog, manual cleanup may be required",
                                                    "Unable to remove catalog for non-empty database",
                                                    "Group does not exist",
                                                    "Unable to remove non-empty group",
                                                    "End of queue",
                                                    "Unable to split because of no sharding index exists",
                                                    "The parameter field does not exist",
                                                    "Too many break points are specified",
                                                    "All prefetchers are busy",
                                                    "Domain does not exist",
                                                    "Domain already exists",
                                                    "Group is not in domain",
                                                    "Sharding type is not hash",
                                                    "split percentage is lower then expected",
                                                    "Task is already finished",
                                                    "Collection is in loading status",
                                                    "Rolling back load operation",
                                                    "RouteID is different from the local",
                                                    "Service already exists",
                                                    "Field is not found",
                                                    "csv field line end",
                                                    "Unknown file type",
                                                    "Exporting configuration does not complete in all nodes",
                                                    "Empty non-primary node",
                                                    "Secret value for index file does not match with data file",
                                                    "Engine version argument is specified",
                                                    "Help argument is specified",
                                                    "Version argument is specified",
                                                    "Stored procedure does not exist",
                                                    "Unable to remove collection partition",
                                                    "Duplicated attach collection partition",
                                                    "Invalid partitioned-collection",
                                                    "New boundary is conflict with the existing boundary",
                                                    "Invalid boundary for the shard",
                                                    "Hit the high water mark",
                                                    "Backup already exists",
                                                    "Backup does not exist",
                                                    "Invalid collection partition",
                                                    "Task is canceled",
                                                    "Sharding type must be ranged partition for partitioned-collection",
                                                    "There is no valid sharding-key defined",
                                                    "Operation is not supported on partitioned-collection",
                                                    "Redefine index",
                                                    "Dropping the collection space is in progress",
                                                    "Hit the limit of maximum number of nodes in the cluster",
                                                    "The node is not in normal status",
                                                    "Node information is expired",
                                                    "Failed to wait for the sync operation from secondary nodes",
                                                    "Transaction is disabled",
                                                    "Data source is running out of connection pool",
                                                    "Too many opened file description",
                                                    "Domain is not empty",
                                                    "The data received by REST is larger than the max size",
                                                    "Failed to build bson object",
                                                    "Stored procedure arguments are out of bound",
                                                    "Unknown REST command",
                                                    "Failed to execute command on data node",
                                                    "The domain is empty",
                                                    "Changing password is required",
                                                    "One or more nodes did not complete successfully",
                                                    "There is another OM Agent running with different version",
                                                    "Task does not exist",
                                                    "Task is rolling back",
                                                    "LOB sequence does not exist",
                                                    "LOB is not useable",
                                                    "Data is not in UTF-8 format",
                                                    "Task failed",
                                                    "Lob does not open",
                                                    "Lob has been open"
                                                };
    }
}