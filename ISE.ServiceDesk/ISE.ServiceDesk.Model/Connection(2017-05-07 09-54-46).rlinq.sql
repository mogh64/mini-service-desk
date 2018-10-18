-- ISE.ServiceDesk.Model.Objecttype


CREATE SEQUENCE "Sq_SD_ATTACHMENT_ATTACHMENT_ID"  START WITH 1  INCREMENT BY 1  NOMAXVALUE  NOCACHE ;

CREATE TRIGGER "Trg_SD_ATTACHMENT_ATTACHMENT_I"  BEFORE INSERT ON "SD_ATTACHMENT"  FOR EACH ROW   BEGIN  SELECT "Sq_SD_ATTACHMENT_ATTACHMENT_ID".nextval INTO :NEW."ATTACHMENT_ID" FROM dual;  END;;

-- ISE.ServiceDesk.Model.SdFilterCategory
CREATE TABLE "SD_FILTER_CATEGORY" (
    "SERVICECAEGORYID" NUMBER(6) NULL,      -- _servicecaegoryid
    "OBJECTTYPEID" NUMBER(6) NULL,          -- _objecttypeid
    "MENUPARENTID" NUMBER(6) NULL,          -- _menuparentid
    "FILTER_ID" NUMBER(6) NOT NULL,         -- _filterid
    CONSTRAINT "pk_SD_FILTER_CATEGORY" PRIMARY KEY ("FILTER_ID")
);

CREATE SEQUENCE "Sq_SD_FILTER_CATEGORY_FILTER_I"  START WITH 1  INCREMENT BY 1  NOMAXVALUE  NOCACHE ;

CREATE TRIGGER "Trg_SD_FILTER_CATEGORY_FILTER_"  BEFORE INSERT ON "SD_FILTER_CATEGORY"  FOR EACH ROW   BEGIN  SELECT "Sq_SD_FILTER_CATEGORY_FILTER_I".nextval INTO :NEW."FILTER_ID" FROM dual;  END;;

-- ISE.ServiceDesk.Model.SdItExpert
CREATE TABLE "SD_IT_EXPERT" (
    "USERID" NUMBER(6) NULL,                -- _userid
    "OFFICEID" NUMBER(6) NULL,              -- _officeid
    "IT_EXPERT_ID" NUMBER(6) NOT NULL,      -- _itexpertid
    CONSTRAINT "pk_SD_IT_EXPERT" PRIMARY KEY ("IT_EXPERT_ID")
);

-- ISE.ServiceDesk.Model.SdItRole
CREATE TABLE "SD_IT_ROLE" (
    "TITLE" VARCHAR2(250) NULL,             -- _title
    "ROLE_ID" NUMBER(6) NOT NULL,           -- _roleid
    "OFFICEID" NUMBER(6) NULL,              -- _officeid
    "DESCRIPTION" VARCHAR2(250) NULL,       -- _description
    CONSTRAINT "pk_SD_IT_ROLE" PRIMARY KEY ("ROLE_ID")
);

-- ISE.ServiceDesk.Model.SdItRoleExpert
CREATE TABLE "SD_IT_ROLE_EXPERT" (
    "WEIGHT" NUMBER(3) NULL,                -- _weight
    "ROLE_EXPERT_ID" NUMBER(6) NOT NULL,    -- _roleexpertid
    "ITROLEID" NUMBER(6) NULL,              -- _itroleid
    "EXPERTID" NUMBER(6) NULL,              -- _expertid
    CONSTRAINT "pk_SD_IT_ROLE_EXPERT" PRIMARY KEY ("ROLE_EXPERT_ID")
);

-- ISE.ServiceDesk.Model.SdOffice
CREATE TABLE "SD_OFFICE" (
    "TITLE" VARCHAR2(250) NULL,             -- _title
    "OFFICE_ID" NUMBER(6) NOT NULL,         -- _officeid
    CONSTRAINT "pk_SD_OFFICE" PRIMARY KEY ("OFFICE_ID")
);

-- ISE.ServiceDesk.Model.SdRequestAssignedExpert
CREATE TABLE "SD_REQUEST_ASSIGNED_EXPERT" (
    "REQUESTID" NUMBER(6) NULL,             -- _requestid
    "REQIEST_EXPERT_ID" NUMBER(6) NOT NULL, -- _reqiestexpertid
    "PRIORITY" NUMBER(3) NULL,              -- _priority
    "ISHEAD" NUMBER(1) NULL,                -- _ishead
    "EXPERTID" NUMBER(6) NULL,              -- _expertid
    "ASSIGNTYPE" NUMBER(2) NULL,            -- _assigntype
    "ASSIGNDATE" DATE NULL,                 -- _assigndate
    CONSTRAINT "pk_SD_REQUEST_ASSIGNED_EXPERT" PRIMARY KEY ("REQIEST_EXPERT_ID")
);

-- ISE.ServiceDesk.Model.SdRequestAttachment
CREATE TABLE "SD_REQUEST_ATTACHMENT" (
    "REUEST_ATTACH_ID" NUMBER(6) NOT NULL,  -- _reuestattachid
    "REQUESTID" NUMBER(6) NULL,             -- _requestid
    "ATTACHMENTID" NUMBER(6) NULL,          -- _attachmentid
    CONSTRAINT "pk_SD_REQUEST_ATTACHMENT" PRIMARY KEY ("REUEST_ATTACH_ID")
);

CREATE SEQUENCE "Sq_SD_REQUEST_ATTACHMENT_REUES"  START WITH 1  INCREMENT BY 1  NOMAXVALUE  NOCACHE ;

CREATE TRIGGER "Trg_SD_REQUEST_ATTACHMENT_REUE"  BEFORE INSERT ON "SD_REQUEST_ATTACHMENT"  FOR EACH ROW   BEGIN  SELECT "Sq_SD_REQUEST_ATTACHMENT_REUES".nextval INTO :NEW."REUEST_ATTACH_ID" FROM dual;  END;;

-- ISE.ServiceDesk.Model.SdRequestProcess
CREATE TABLE "SD_REQUEST_PROCESS" (
    "TIMECOST" NUMBER(22) NULL,             -- _timecost
    "SERVICECATEGORYJOBID" NUMBER(6) NULL,  -- _servicecategoryjobid
    "REQUESTID" NUMBER(6) NULL,             -- _requestid
    "REQ_PROCESS_ID" NUMBER(6) NOT NULL,    -- _reqprocessid
    "PROCESSDATE" DATE NULL,                -- _processdate
    "ITEXPERTID" NUMBER(6) NULL,            -- _itexpertid
    "FINANCIALCOST" NUMBER(6) NULL,         -- _financialcost
    "DESCRIPTION" VARCHAR2(250) NULL,       -- _description
    CONSTRAINT "pk_SD_REQUEST_PROCESS" PRIMARY KEY ("REQ_PROCESS_ID")
);

-- ISE.ServiceDesk.Model.SdRequestState
CREATE TABLE "SD_REQUEST_STATE" (
    "STATE_TITLE" VARCHAR2(50) NULL,        -- _statetitle
    "SD_REQ_STATE_ID" NUMBER(6) NOT NULL,   -- _sdreqstateid
    CONSTRAINT "pk_SD_REQUEST_STATE" PRIMARY KEY ("SD_REQ_STATE_ID")
);

-- ISE.ServiceDesk.Model.SdServiceCategory
CREATE TABLE "SD_SERVICE_CATEGORY" (
    "TITLE" VARCHAR2(250) NULL,             -- _title
    "SERVICE_CAT_ID" NUMBER(6) NOT NULL,    -- _servicecatid
    "PARENTID" NUMBER(6) NULL,              -- _parentid
    "HASMENU" NUMBER(1) NULL,               -- _hasmenu
    "HASJOB" NUMBER(1) NULL,                -- _hasjob
    "HASFILTER" NUMBER(1) NULL,             -- _hasfilter
    "HASDEVICE" NUMBER(1) NULL,             -- _hasdevice
    "ENABLED" NUMBER(1) NULL,               -- _enabled
    "DESCRIPTION" VARCHAR2(250) NULL,       -- _description
    CONSTRAINT "pk_SD_SERVICE_CATEGORY" PRIMARY KEY ("SERVICE_CAT_ID")
);

CREATE SEQUENCE "Sq_SD_SERVICE_CATEGORY_SERVICE"  START WITH 1  INCREMENT BY 1  NOMAXVALUE  NOCACHE ;

CREATE TRIGGER "Trg_SD_SERVICE_CATEGORY_SERVIC"  BEFORE INSERT ON "SD_SERVICE_CATEGORY"  FOR EACH ROW   BEGIN  SELECT "Sq_SD_SERVICE_CATEGORY_SERVICE".nextval INTO :NEW."SERVICE_CAT_ID" FROM dual;  END;;

-- ISE.ServiceDesk.Model.SdServiceCategoryJob
CREATE TABLE "SD_SERVICE_CATEGORY_JOB" (
    "SERVICEJOBID" NUMBER(6) NULL,          -- _servicejobid
    "SERVICECATEGORYID" NUMBER(6) NULL,     -- _servicecategoryid
    "SERVICE_CAT_JOB_ID" NUMBER(6) NOT NULL, -- _servicecatjobid
    "ROLEID" NUMBER(6) NULL,                -- _roleid
    "PRECEDENCE" NUMBER(3) NULL,            -- _precedence
    "MULTIREQUEST" NUMBER(1) NULL,          -- _multirequest
    "ISINTREE" NUMBER(1) NULL,              -- _isintree
    "IS_INSERTER" NUMBER(1) NULL,           -- _isinserter
    "HASDESCRIPTION" NUMBER(1) NULL,        -- _hasdescription
    "HASCREDITDATE" NUMBER(1) NULL,         -- _hascreditdate
    "HASATTACHMENT" NUMBER(1) NULL,         -- _hasattachment
    "ESTIMATETIMECOST" NUMBER(6) NULL,      -- _estimatetimecost
    "ACTIONID" NUMBER(6) NULL,              -- _actionid
    CONSTRAINT "pk_SD_SERVICE_CATEGORY_JOB" PRIMARY KEY ("SERVICE_CAT_JOB_ID")
);

CREATE SEQUENCE "Sq_SD_SERVICE_CATEGORY_JOB_SER"  START WITH 1  INCREMENT BY 1  NOMAXVALUE  NOCACHE ;

CREATE TRIGGER "Trg_SD_SERVICE_CATEGORY_JOB_SE"  BEFORE INSERT ON "SD_SERVICE_CATEGORY_JOB"  FOR EACH ROW   BEGIN  SELECT "Sq_SD_SERVICE_CATEGORY_JOB_SER".nextval INTO :NEW."SERVICE_CAT_JOB_ID" FROM dual;  END;;

-- ISE.ServiceDesk.Model.SdServiceJob
CREATE TABLE "SD_SERVICE_JOB" (
    "TITLE" VARCHAR2(250) NULL,             -- _title
    "SERVICE_JOB_ID" NUMBER(6) NOT NULL,    -- _servicejobid
    "ENABLED" NUMBER(1) NULL,               -- _enabled
    "DESCRIPTION" VARCHAR2(250) NULL,       -- _description
    CONSTRAINT "pk_SD_SERVICE_JOB" PRIMARY KEY ("SERVICE_JOB_ID")
);

CREATE SEQUENCE "Sq_SD_SERVICE_JOB_SERVICE_JOB_"  START WITH 1  INCREMENT BY 1  NOMAXVALUE  NOCACHE ;

CREATE TRIGGER "Trg_SD_SERVICE_JOB_SERVICE_JOB"  BEFORE INSERT ON "SD_SERVICE_JOB"  FOR EACH ROW   BEGIN  SELECT "Sq_SD_SERVICE_JOB_SERVICE_JOB_".nextval INTO :NEW."SERVICE_JOB_ID" FROM dual;  END;;

-- ISE.ServiceDesk.Model.SdUserRequest
CREATE TABLE "SD_USER_REQUEST" (
    "TRANSFERID" NUMBER(9) NULL,            -- _transferid
    "STARTDATE" DATE NULL,                  -- _startdate
    "SERVICECATEGORYJOBID" NUMBER(6) NULL,  -- _servicecategoryjobid
    "SER_REQ_ID" NUMBER(6) NOT NULL,        -- _serreqid
    "CURRENTSTATEID" NUMBER(6) NULL,        -- _sdrequeststate
    "OWNERUSERID" NUMBER(6) NULL,           -- _owneruserid
    "MINESTIMATETIME" NUMBER(6) NULL,       -- _minestimatetime
    "MENUITEMID" NUMBER(6) NULL,            -- _menuitemid
    "MAXESTIMATETIME" NUMBER(6) NULL,       -- _maxestimatetime
    "GROUPINGNUMBER" NUMBER(6) NULL,        -- _groupingnumber
    "FINALSERVICECATEGORYJOBID" NUMBER(6) NULL, -- _finalservicecategoryjobid
    "FINALDESCRIPTION" VARCHAR2(250) NULL,  -- _finaldescription
    "ENDDATE" DATE NULL,                    -- _enddate
    "DESCRIPTION" VARCHAR2(250) NULL,       -- _description
    "CREDITDATE" DATE NULL,                 -- _creditdate
    "CREATEUSERID" NUMBER(6) NULL,          -- _createuserid
    "CREATEDATE" DATE NULL,                 -- _createdate
    "CALLNUMBER" VARCHAR2(15) NULL,         -- _callnumber
    CONSTRAINT "pk_SD_USER_REQUEST" PRIMARY KEY ("SER_REQ_ID")
);

CREATE SEQUENCE "Seq_SD_USER_REQUEST_SER_REQ_ID"  START WITH 1  INCREMENT BY 1  NOMAXVALUE  NOCACHE ;

CREATE TRIGGER "Trg_SD_USER_REQUEST_SER_REQ_ID"  BEFORE INSERT ON "SD_USER_REQUEST"  FOR EACH ROW   BEGIN  SELECT "Seq_SD_USER_REQUEST_SER_REQ_ID".nextval INTO :NEW."SER_REQ_ID" FROM dual;  END;;

CREATE INDEX "idx_SD_USER_REQUEST_CURRENTSTA" ON "SD_USER_REQUEST"("CURRENTSTATEID");

ALTER TABLE "SD_USER_REQUEST" ADD CONSTRAINT "FKEY_REQUEST_STATE" FOREIGN KEY ("CURRENTSTATEID") REFERENCES "SD_REQUEST_STATE"("SD_REQ_STATE_ID");

