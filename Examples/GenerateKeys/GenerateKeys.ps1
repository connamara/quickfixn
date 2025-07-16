$rootCert = New-SelfSignedCertificate -Subject "CN=QuickFixn-TestCA" -Type Custom -KeyUsage CertSign, CRLSign, DigitalSignature -SuppressOid "2.5.29.37" -KeyLength 2048 -NotAfter (Get-Date).AddDays(30)

$rootCertPath = "QuickFixn-TestCA.cer"
Export-Certificate -Cert $rootCert -FilePath $rootCertPath

$serverCert = New-SelfSignedCertificate -Subject "CN=QuickFixn-TestServer" -DnsName localhost, 127.0.0.1 -Signer $rootCert -KeyUsage DigitalSignature, KeyEncipherment -TextExtension "2.5.29.37={text}1.3.6.1.5.5.7.3.1" -KeyLength 2048 -NotAfter (Get-Date).AddDays(5)
$serverCertPath = "QuickFixn-TestServer.pfx"
$password = ConvertTo-SecureString -String "qfnpass123" -Force -AsPlainText
Export-Certificate -Cert $serverCert -FilePath "QuickFixn-TestServer.cer"
Export-PfxCertificate -Cert $serverCert -FilePath $serverCertPath -Password $password


$clientCert = New-SelfSignedCertificate -Subject "CN=QuickFixn-TestClient" -DnsName localhost, 127.0.0.1 -Signer $rootCert -KeyUsage DigitalSignature, KeyEncipherment -TextExtension "2.5.29.37={text}1.3.6.1.5.5.7.3.2" -KeyLength 2048 -NotAfter (Get-Date).AddDays(5)
$clientCertPath = "QuickFixn-TestClient.pfx"
$password = ConvertTo-SecureString -String "qfnpass123" -Force -AsPlainText
Export-Certificate -Cert $clientCert -FilePath "QuickFixn-TestClient.cer"
Export-PfxCertificate -Cert $clientCert -FilePath $clientCertPath -Password $password