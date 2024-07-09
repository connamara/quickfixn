###################
# Generate CA cert
# (may not need SAN here)

openssl req -x509 -newkey rsa:4096 -sha256 -days 3650 \
  -nodes -keyout quickfixn-CA.demo.key -out quickfixn-CA.demo.cer -subj "/CN=quickfixn-CA.demo" \
  -addext "subjectAltName=DNS:localhost,IP:127.0.0.1"


# I'm using "qfnpass123" for all passwords

openssl pkcs12 -export -out quickfixn-CA.demo.pfx -inkey quickfixn-CA.demo.key -in quickfixn-CA.demo.cer


