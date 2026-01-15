# CME Enhanced Resend details


## Config settings needed by any app that uses CME Enhanced Resend:

These configs enable the CME Enhanced Resend behaviors in the QF/n engine:

```
# Yes CME wants tag 369
EnableLastMsgSeqNumProcessed=Y

# CME "hacks" mode -- CME has some quirky behaviors that are handled when this setting is enabled.
# 1: If CME sends a Logout with 789/NextExpectedMsgSeqNum=1, then the logout response must be seq=1,
#    and the following login must be 2.
# 2: An ugly hack to implement CME's variant gap fill behavior properly.
CmeMode=Y

# CME mandates that this be 2500 or less
MaxMessagesInResendRequest=2500

# I'm not sure if we actually need this one
# (It allows SequenceReset messages and PossDup messages to be accepted if they lack 122,
#  but I don't see examples of that in my Autocert success logs)
RequiresOrigSendingTime=N
```


## DataDictionary

* CME includes NextExpectedMsgSeqNum (789) in the body of their Logout message.

* CME has a Logon procedure that uses special logic that is not included in QF/n.  You will need to implement it.

    It requires the following fields be added to the Logon message body in your DD:


    ```
    <field name="EncodedTextLen" required="N"/>
    <field name="EncodedText" required="N"/>

    <field name="CmeEncryptedPasswordMethod" required="N"/>
    <field name="EncryptedPasswordLen" required="N"/>
    <field name="EncryptedPassword" required="N"/>

    <field name="ApplicationSystemName" required="N"/>
    <field name="ApplicationSystemVersion" required="N"/>
    <field name="ApplicationSystemVendor" required="N"/>

    <!--
         ...
    -->

    <field number="1400" name="CmeEncryptedPasswordMethod" type="STRING"/> <!-- standard field is INT, not STRING -->
    <field number="1401" name="EncryptedPasswordLen" type="LENGTH" />
    <field number="1402" name="EncryptedPassword" type="DATA" />

    <field number="1603" name="ApplicationSystemName" type="STRING"/>
    <field number="1604" name="ApplicationSystemVersion" type="STRING"/>
    <field number="1605" name="ApplicationSystemVendor" type="STRING"/>

    ```

* If using FIX42, you'll need to add this message to your DD:

    ```
    <message name="XMLnonFIX" msgtype="n" msgcat="admin">
      <!-- this message has no body fields -->
    </message>
    ```


