<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0"	
                exclude-result-prefixes="msxsl"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
		xmlns:msxsl="urn:schemas-microsoft-com:xslt">
<xsl:output method="html" indent="no" />
<xsl:template match="at">
	<html><body><h2>QuickFIX.NET Acceptance Tests</h2>
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
				<tr bgcolor="#ffbb00">
					<td>Failure</td>
					<td><tt><xsl:value-of select="@failures"/> (<xsl:value-of select="round(number(@failures) div number(@total) * 1000) div 10" />%)</tt></td>
				</tr>
			</xsl:for-each>
		</table>
	</body></html>
</xsl:template>
</xsl:stylesheet>
