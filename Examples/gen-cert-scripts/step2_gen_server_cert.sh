###################
# Generate Server cert

openssl req -new -nodes -newkey rsa:4096 \
  -keyout qfn-server.demo.key \
  -out qfn-server.demo.csr \
  -subj "/CN=qfn-server.demo" \
  -addext "subjectAltName=DNS:localhost,IP:127.0.0.1" \
  -addext "extendedKeyUsage=serverAuth"

openssl x509 -req -in qfn-server.demo.csr -CA quickfixn-CA.demo.cer -CAkey quickfixn-CA.demo.key \
  -CAcreateserial -out qfn-server.demo.cer -days 3650 -sha256 -copy_extensions copy

openssl pkcs12 -export -out qfn-server.demo.pfx -inkey qfn-server.demo.key -in qfn-server.demo.cer


