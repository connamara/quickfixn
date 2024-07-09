###################
# Generate Client cert

openssl req -new -nodes -newkey rsa:4096 \
  -keyout qfn-client.demo.key \
  -out qfn-client.demo.csr \
  -subj "/CN=qfn-client.demo" \
  -addext "subjectAltName=DNS:localhost,IP:127.0.0.1" \
  -addext "extendedKeyUsage=clientAuth"

openssl x509 -req -in qfn-client.demo.csr -CA quickfixn-CA.demo.cer -CAkey quickfixn-CA.demo.key \
  -CAcreateserial -out qfn-client.demo.cer -days 3650 -sha256 -copy_extensions copy

openssl pkcs12 -export -out qfn-client.demo.pfx -inkey qfn-client.demo.key -in qfn-client.demo.cer



