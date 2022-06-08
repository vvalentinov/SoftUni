function requestValidator(request) {
    if (!request.hasOwnProperty('method')) {
        throw new Error(`Invalid request header: Invalid Method`);
    } else if (!request.hasOwnProperty('uri')) {
        throw new Error(`Invalid request header: Invalid URI`);
    } else if (!request.hasOwnProperty('version')) {
        throw new Error(`Invalid request header: Invalid Version`);
    } else if (!request.hasOwnProperty('message')) {
        throw new Error(`Invalid request header: Invalid Message`);
    }

    let uriPattern = /^[a-zA-Z.0-9*]+$/gm;
    let messagePattern = /^[^<>\\&'"]*$/gm;

    for (const [key, value] of Object.entries(request)) {
        switch (key) {
            case 'method':
                if (value != 'GET' && value != 'POST' && value != 'DELETE' && value != 'CONNECT') {
                    throw new Error(`Invalid request header: Invalid Method`);
                }
                break;
            case 'uri':
                if (value.match(uriPattern) == null) {
                    throw new Error(`Invalid request header: Invalid URI`);
                }
                break;
            case 'version':
                if (value != 'HTTP/0.9' && value != 'HTTP/1.0' && value != 'HTTP/1.1' && value != 'HTTP/2.0') {
                    throw new Error(`Invalid request header: Invalid Version`);
                }
                break;
            case 'message':
                if (value.match(messagePattern) == null) {
                    throw new Error(`Invalid request header: Invalid Message`);
                }
                break;
        }
    }
    return request;
}