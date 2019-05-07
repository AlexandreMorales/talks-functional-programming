import React from 'react'
import { CodeSurfer } from "mdx-deck-code-surfer"

const Loader = () =>
    <CodeSurfer
        title="Some Title"
        code={require("!raw-loader!./my-snippet.js")}
        lang="javascript"
        showNumbers={false}
        dark={false}
        steps={[
            { notes: "Start with this note" },
            { lines: [6], notes: "Note for the first step" },
            { range: [5, 9] },
            { tokens: { 9: [3, 4, 5] }, notes: "Note for the third step" }
        ]}
    />

export default Loader
