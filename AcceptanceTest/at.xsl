<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0"	
                exclude-result-prefixes="msxsl"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
		xmlns:msxsl="urn:schemas-microsoft-com:xslt">
<xsl:output method="html" indent="yes" />
<xsl:template match="at">
	<html><body><h2>QuickFIX/n Acceptance Tests</h2>
		<table border="0" cellspacing="2" cellpadding="2">
			<xsl:for-each select="results">
				<xsl:variable name="success" select="@total - @failures" />
				<tr bgcolor="#dddddd">
					<td>Number of Tests</td>
					<td><tt><xsl:value-of select="@total"/></tt></td>
				</tr>
				<tr bgcolor="#99ff00">
					<td>Success</td>
					<td><tt><xsl:value-of select="$success"/> (<xsl:value-of select="round(number($success) div number(@total) * 1000) div 10" />%)</tt></td>
				</tr>
				<tr bgcolor="#ff6666">
					<td>Failure</td>
					<td><tt><xsl:value-of select="@failures"/> (<xsl:value-of select="round(number(@failures) div number(@total) * 1000) div 10" />%)</tt></td>
				</tr>
			</xsl:for-each>
		</table>
		<br/>
		<table border="0" cellspacing="2" cellpadding="4">
			<tr bgcolor="#6688dd">
				<th>Test Name</th>
				<th>Result</th>
			</tr>
			<xsl:for-each select="test">
				<xsl:choose>
					<xsl:when test="@result = 'success'">
						<tr bgcolor="#99ff00">
							<td><xsl:value-of select="substring-after(@name,'definitions/server/')"/></td>
							<td>Success</td>
						</tr>
					</xsl:when>
					<xsl:otherwise> 
						<tr bgcolor="#ff6666">
							<td>
								<xsl:value-of select="substring-after(@name,'definitions/server/')"/><br/>
								<xsl:for-each select="message">
									<tt><xsl:text disable-output-escaping="yes">&amp;nbsp;&amp;nbsp;</xsl:text>Failure at line <xsl:value-of select="line"/>: <xsl:value-of select="text()"/></tt><br/>
									<xsl:for-each select="expected">
										<tt><xsl:text disable-output-escaping="yes">&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;</xsl:text>Expected: <xsl:value-of select="."/></tt><br/>
									</xsl:for-each>
									<xsl:for-each select="received">
										<tt><xsl:text disable-output-escaping="yes">&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;</xsl:text>Received: <xsl:value-of select="."/></tt>
									</xsl:for-each>
								</xsl:for-each>
							</td>
							<td>Failure</td>
						</tr>
					</xsl:otherwise>
				</xsl:choose>
			</xsl:for-each>
		</table>
	</body></html>
</xsl:template>
</xsl:stylesheet>
