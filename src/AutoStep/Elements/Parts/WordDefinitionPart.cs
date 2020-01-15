﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using AutoStep.Compiler;
using AutoStep.Compiler.Matching;
using AutoStep.Definitions;
using AutoStep.Elements.StepTokens;

namespace AutoStep.Elements.Parts
{
    /// <summary>
    /// Represents a word part of a step definition (i.e. a block of literal text).
    /// </summary>
    internal class WordDefinitionPart : DefinitionPart
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WordDefinitionPart"/> class.
        /// </summary>
        /// <param name="text">The text of the part.</param>
        public WordDefinitionPart(string text)
            : base(text)
        {
        }

        /// <inheritdoc/>
        public override StepReferenceMatchResult DoStepReferenceMatch(string referenceText, ReadOnlySpan<StepToken> currentPartSpan)
        {
            // The word definition part should:
            // - Consume text from the current part as much as it can (until either it has consumed all the text in the part or this word has run out of content)
            // - Return a match with the span after we've done our bit.
            var defTextSpan = Text.AsSpan();
            var currentPart = currentPartSpan[0];
            var refTextSpan = referenceText.AsSpan(currentPart.StartIndex, currentPart.Length);

            int matchedLength = 0;

            // While we have some text left in this part.
            while (!defTextSpan.IsEmpty)
            {
                // This word definition is bigger than the matching text then we may need to consume
                // multiple parts.
                if (defTextSpan.Length > refTextSpan.Length)
                {
                    if (defTextSpan.StartsWith(refTextSpan, StringComparison.CurrentCulture))
                    {
                        matchedLength += refTextSpan.Length;

                        // The refTextSpan starts with the reference text, so it's been matched.
                        // Move the defTextSpan along and move to the next part.
                        defTextSpan = defTextSpan.Slice(refTextSpan.Length);

                        // Move to the next part.
                        currentPartSpan = currentPartSpan.Slice(1);

                        if (currentPartSpan.IsEmpty)
                        {
                            // Out of reference parts; suggests a partial match on this part.
                            return new StepReferenceMatchResult(matchedLength, false, currentPartSpan);
                        }
                        else
                        {
                            currentPart = currentPartSpan[0];
                            refTextSpan = referenceText.AsSpan(currentPart.StartIndex, currentPart.Length);
                        }
                    }
                    else
                    {
                        // Not a match.
                        return new StepReferenceMatchResult(matchedLength, false, currentPartSpan);
                    }
                }
                else
                {
                    var searchedCharacters = 0;
                    while (searchedCharacters < refTextSpan.Length && refTextSpan[searchedCharacters].Equals(defTextSpan[searchedCharacters]))
                    {
                        searchedCharacters++;
                    }

                    // This tells us how many characters matched.
                    matchedLength += searchedCharacters;

                    // Move the part span along.
                    currentPartSpan = currentPartSpan.Slice(1);

                    return new StepReferenceMatchResult(matchedLength, defTextSpan.Length == searchedCharacters, currentPartSpan);
                }
            }

            return new StepReferenceMatchResult(matchedLength, false, currentPartSpan);
        }

        /// <inheritdoc/>
        public override bool IsDefinitionPartMatch(DefinitionPart part)
        {
            return part is DefinitionPart wrd && wrd.Text == Text;
        }
    }
}