using System.Collections.Generic;

namespace QuickFix.FixValues;

public class BusinessRejectReason
{
    public static readonly Dictionary<int, string> RejText = new()
    {
        { Fields.BusinessRejectReason.OTHER, "Other" },
        { Fields.BusinessRejectReason.UNKNOWN_ID, "Unknown ID" },
        { Fields.BusinessRejectReason.UNKNOWN_SECURITY, "Unknown Security" },
        { Fields.BusinessRejectReason.UNKNOWN_MESSAGE_TYPE, "Unsupported Message Type" },
        { Fields.BusinessRejectReason.APPLICATION_NOT_AVAILABLE, "Application Not Available" },
        { Fields.BusinessRejectReason.CONDITIONALLY_REQUIRED_FIELD_MISSING, "Conditionally Required Field Missing" },
        { Fields.BusinessRejectReason.NOT_AUTHORIZED, "Not authorized" },
        { Fields.BusinessRejectReason.DELIVERTO_FIRM_NOT_AVAILABLE_AT_THIS_TIME, "DeliverTo Firm Not Available At This Time" }
    };
}
