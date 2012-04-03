#region (c) 2010-2012 Lokad - CQRS Sample for Windows Azure - New BSD License 

// Copyright (c) Lokad 2010-2012, http://www.lokad.com
// This code is released as Open Source under the terms of the New BSD Licence

#endregion

#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591


using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Antlr.Runtime;

namespace MessageContracts
{
    [GeneratedCode("ANTLR", "3.4")]
    [CLSCompliant(false)]
    public partial class MessageContractsLexer : Lexer
    {
        public const int EOF = -1;
        public const int T__23 = 23;
        public const int T__24 = 24;
        public const int T__25 = 25;
        public const int T__26 = 26;
        public const int T__27 = 27;
        public const int BlockToken = 4;
        public const int COMMENT = 5;
        public const int CommandToken = 6;
        public const int DisctionaryToken = 7;
        public const int ENTITY = 8;
        public const int EntityDefinition = 9;
        public const int EventToken = 10;
        public const int FragmentEntry = 11;
        public const int FragmentGroup = 12;
        public const int FragmentReference = 13;
        public const int ID = 14;
        public const int INT = 15;
        public const int LET = 16;
        public const int MemberToken = 17;
        public const int Modifier = 18;
        public const int ModifierDefinition = 19;
        public const int TypeToken = 20;
        public const int USING = 21;
        public const int WS = 22;

        // delegates
        // delegators

        public MessageContractsLexer()
        {
            OnCreated();
        }

        public MessageContractsLexer(ICharStream input)
            : this(input, new RecognizerSharedState()) {}

        public MessageContractsLexer(ICharStream input, RecognizerSharedState state)
            : base(input, state)
        {
            OnCreated();
        }

        public override string GrammarFileName
        {
            get { return "/Users/abdullin/MessageContracts.g"; }
        }

        static readonly bool[] decisionCanBacktrack = new bool[0];

        [Conditional("ANTLR_TRACE")]
        protected virtual void OnCreated() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule(string ruleName, int ruleIndex) {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_T__23() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_T__23() {}

        // $ANTLR start "T__23"
        [GrammarRule("T__23")]
        void mT__23()
        {
            EnterRule_T__23();
            EnterRule("T__23", 1);
            TraceIn("T__23", 1);
            try
            {
                int _type = T__23;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:9:7: ( '(' )
                DebugEnterAlt(1);
                // /Users/abdullin/MessageContracts.g:9:9: '('
                {
                    DebugLocation(9, 9);
                    Match('(');
                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__23", 1);
                LeaveRule("T__23", 1);
                LeaveRule_T__23();
            }
        }

        // $ANTLR end "T__23"

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_T__24() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_T__24() {}

        // $ANTLR start "T__24"
        [GrammarRule("T__24")]
        void mT__24()
        {
            EnterRule_T__24();
            EnterRule("T__24", 2);
            TraceIn("T__24", 2);
            try
            {
                int _type = T__24;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:10:7: ( ')' )
                DebugEnterAlt(1);
                // /Users/abdullin/MessageContracts.g:10:9: ')'
                {
                    DebugLocation(10, 9);
                    Match(')');
                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__24", 2);
                LeaveRule("T__24", 2);
                LeaveRule_T__24();
            }
        }

        // $ANTLR end "T__24"

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_T__25() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_T__25() {}

        // $ANTLR start "T__25"
        [GrammarRule("T__25")]
        void mT__25()
        {
            EnterRule_T__25();
            EnterRule("T__25", 3);
            TraceIn("T__25", 3);
            try
            {
                int _type = T__25;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:11:7: ( ',' )
                DebugEnterAlt(1);
                // /Users/abdullin/MessageContracts.g:11:9: ','
                {
                    DebugLocation(11, 9);
                    Match(',');
                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__25", 3);
                LeaveRule("T__25", 3);
                LeaveRule_T__25();
            }
        }

        // $ANTLR end "T__25"

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_T__26() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_T__26() {}

        // $ANTLR start "T__26"
        [GrammarRule("T__26")]
        void mT__26()
        {
            EnterRule_T__26();
            EnterRule("T__26", 4);
            TraceIn("T__26", 4);
            try
            {
                int _type = T__26;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:12:7: ( ';' )
                DebugEnterAlt(1);
                // /Users/abdullin/MessageContracts.g:12:9: ';'
                {
                    DebugLocation(12, 9);
                    Match(';');
                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__26", 4);
                LeaveRule("T__26", 4);
                LeaveRule_T__26();
            }
        }

        // $ANTLR end "T__26"

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_T__27() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_T__27() {}

        // $ANTLR start "T__27"
        [GrammarRule("T__27")]
        void mT__27()
        {
            EnterRule_T__27();
            EnterRule("T__27", 5);
            TraceIn("T__27", 5);
            try
            {
                int _type = T__27;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:13:7: ( '=' )
                DebugEnterAlt(1);
                // /Users/abdullin/MessageContracts.g:13:9: '='
                {
                    DebugLocation(13, 9);
                    Match('=');
                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__27", 5);
                LeaveRule("T__27", 5);
                LeaveRule_T__27();
            }
        }

        // $ANTLR end "T__27"

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_USING() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_USING() {}

        // $ANTLR start "USING"
        [GrammarRule("USING")]
        void mUSING()
        {
            EnterRule_USING();
            EnterRule("USING", 6);
            TraceIn("USING", 6);
            try
            {
                int _type = USING;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:65:2: ( 'using' )
                DebugEnterAlt(1);
                // /Users/abdullin/MessageContracts.g:65:4: 'using'
                {
                    DebugLocation(65, 4);
                    Match("using");
                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("USING", 6);
                LeaveRule("USING", 6);
                LeaveRule_USING();
            }
        }

        // $ANTLR end "USING"

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_LET() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_LET() {}

        // $ANTLR start "LET"
        [GrammarRule("LET")]
        void mLET()
        {
            EnterRule_LET();
            EnterRule("LET", 7);
            TraceIn("LET", 7);
            try
            {
                int _type = LET;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:67:2: ( 'let' )
                DebugEnterAlt(1);
                // /Users/abdullin/MessageContracts.g:67:4: 'let'
                {
                    DebugLocation(67, 4);
                    Match("let");
                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("LET", 7);
                LeaveRule("LET", 7);
                LeaveRule_LET();
            }
        }

        // $ANTLR end "LET"

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_ENTITY() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_ENTITY() {}

        // $ANTLR start "ENTITY"
        [GrammarRule("ENTITY")]
        void mENTITY()
        {
            EnterRule_ENTITY();
            EnterRule("ENTITY", 8);
            TraceIn("ENTITY", 8);
            try
            {
                int _type = ENTITY;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:68:9: ( 'entity' )
                DebugEnterAlt(1);
                // /Users/abdullin/MessageContracts.g:68:11: 'entity'
                {
                    DebugLocation(68, 11);
                    Match("entity");
                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("ENTITY", 8);
                LeaveRule("ENTITY", 8);
                LeaveRule_ENTITY();
            }
        }

        // $ANTLR end "ENTITY"

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_ID() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_ID() {}

        // $ANTLR start "ID"
        [GrammarRule("ID")]
        void mID()
        {
            EnterRule_ID();
            EnterRule("ID", 9);
            TraceIn("ID", 9);
            try
            {
                int _type = ID;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:69:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '<' | '>' | '[' | ']' )* )
                DebugEnterAlt(1);
                // /Users/abdullin/MessageContracts.g:69:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '<' | '>' | '[' | ']' )*
                {
                    DebugLocation(69, 7);
                    if ((input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' ||
                        (input.LA(1) >= 'a' && input.LA(1) <= 'z'))
                    {
                        input.Consume();
                    }
                    else
                    {
                        MismatchedSetException mse = new MismatchedSetException(null, input);
                        DebugRecognitionException(mse);
                        Recover(mse);
                        throw mse;
                    }

                    DebugLocation(69, 30);
                    // /Users/abdullin/MessageContracts.g:69:30: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '<' | '>' | '[' | ']' )*
                    try
                    {
                        DebugEnterSubRule(1);
                        while (true)
                        {
                            int alt1 = 2;
                            try
                            {
                                DebugEnterDecision(1, decisionCanBacktrack[1]);
                                int LA1_0 = input.LA(1);

                                if (((LA1_0 >= '0' && LA1_0 <= '9') || LA1_0 == '<' || LA1_0 == '>' ||
                                    (LA1_0 >= 'A' && LA1_0 <= '[') || LA1_0 == ']' || LA1_0 == '_' ||
                                        (LA1_0 >= 'a' && LA1_0 <= 'z')))
                                {
                                    alt1 = 1;
                                }
                            }
                            finally
                            {
                                DebugExitDecision(1);
                            }
                            switch (alt1)
                            {
                                case 1:
                                    DebugEnterAlt(1);
                                    // /Users/abdullin/MessageContracts.g:
                                    {
                                        DebugLocation(69, 30);
                                        input.Consume();
                                    }
                                    break;

                                default:
                                    goto loop1;
                            }
                        }

                        loop1:
                        ;
                    }
                    finally
                    {
                        DebugExitSubRule(1);
                    }
                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("ID", 9);
                LeaveRule("ID", 9);
                LeaveRule_ID();
            }
        }

        // $ANTLR end "ID"

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_Modifier() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_Modifier() {}

        // $ANTLR start "Modifier"
        [GrammarRule("Modifier")]
        void mModifier()
        {
            EnterRule_Modifier();
            EnterRule("Modifier", 10);
            TraceIn("Modifier", 10);
            try
            {
                int _type = Modifier;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:73:2: ( '?' | '!' | ';' | ':' | '$' | '+' | '-' | '@' )
                DebugEnterAlt(1);
                // /Users/abdullin/MessageContracts.g:
                {
                    DebugLocation(73, 2);
                    if (input.LA(1) == '!' || input.LA(1) == '$' || input.LA(1) == '+' || input.LA(1) == '-' ||
                        (input.LA(1) >= ':' && input.LA(1) <= ';') || (input.LA(1) >= '?' && input.LA(1) <= '@'))
                    {
                        input.Consume();
                    }
                    else
                    {
                        MismatchedSetException mse = new MismatchedSetException(null, input);
                        DebugRecognitionException(mse);
                        Recover(mse);
                        throw mse;
                    }
                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("Modifier", 10);
                LeaveRule("Modifier", 10);
                LeaveRule_Modifier();
            }
        }

        // $ANTLR end "Modifier"

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_INT() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_INT() {}

        // $ANTLR start "INT"
        [GrammarRule("INT")]
        void mINT()
        {
            EnterRule_INT();
            EnterRule("INT", 11);
            TraceIn("INT", 11);
            try
            {
                int _type = INT;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:84:5: ( ( '0' .. '9' )+ )
                DebugEnterAlt(1);
                // /Users/abdullin/MessageContracts.g:84:7: ( '0' .. '9' )+
                {
                    DebugLocation(84, 7);
                    // /Users/abdullin/MessageContracts.g:84:7: ( '0' .. '9' )+
                    int cnt2 = 0;
                    try
                    {
                        DebugEnterSubRule(2);
                        while (true)
                        {
                            int alt2 = 2;
                            try
                            {
                                DebugEnterDecision(2, decisionCanBacktrack[2]);
                                int LA2_0 = input.LA(1);

                                if (((LA2_0 >= '0' && LA2_0 <= '9')))
                                {
                                    alt2 = 1;
                                }
                            }
                            finally
                            {
                                DebugExitDecision(2);
                            }
                            switch (alt2)
                            {
                                case 1:
                                    DebugEnterAlt(1);
                                    // /Users/abdullin/MessageContracts.g:
                                    {
                                        DebugLocation(84, 7);
                                        input.Consume();
                                    }
                                    break;

                                default:
                                    if (cnt2 >= 1)
                                        goto loop2;

                                    EarlyExitException eee2 = new EarlyExitException(2, input);
                                    DebugRecognitionException(eee2);
                                    throw eee2;
                            }
                            cnt2++;
                        }
                        loop2:
                        ;
                    }
                    finally
                    {
                        DebugExitSubRule(2);
                    }
                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("INT", 11);
                LeaveRule("INT", 11);
                LeaveRule_INT();
            }
        }

        // $ANTLR end "INT"

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_COMMENT() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_COMMENT() {}

        // $ANTLR start "COMMENT"
        [GrammarRule("COMMENT")]
        void mCOMMENT()
        {
            EnterRule_COMMENT();
            EnterRule("COMMENT", 12);
            TraceIn("COMMENT", 12);
            try
            {
                int _type = COMMENT;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:88:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
                int alt6 = 2;
                try
                {
                    DebugEnterDecision(6, decisionCanBacktrack[6]);
                    int LA6_0 = input.LA(1);

                    if ((LA6_0 == '/'))
                    {
                        int LA6_1 = input.LA(2);

                        if ((LA6_1 == '/'))
                        {
                            alt6 = 1;
                        }
                        else if ((LA6_1 == '*'))
                        {
                            alt6 = 2;
                        }
                        else
                        {
                            NoViableAltException nvae = new NoViableAltException("", 6, 1, input);
                            DebugRecognitionException(nvae);
                            throw nvae;
                        }
                    }
                    else
                    {
                        NoViableAltException nvae = new NoViableAltException("", 6, 0, input);
                        DebugRecognitionException(nvae);
                        throw nvae;
                    }
                }
                finally
                {
                    DebugExitDecision(6);
                }
                switch (alt6)
                {
                    case 1:
                        DebugEnterAlt(1);
                        // /Users/abdullin/MessageContracts.g:88:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                        {
                            DebugLocation(88, 9);
                            Match("//");

                            DebugLocation(88, 14);
                            // /Users/abdullin/MessageContracts.g:88:14: (~ ( '\\n' | '\\r' ) )*
                            try
                            {
                                DebugEnterSubRule(3);
                                while (true)
                                {
                                    int alt3 = 2;
                                    try
                                    {
                                        DebugEnterDecision(3, decisionCanBacktrack[3]);
                                        int LA3_0 = input.LA(1);

                                        if (((LA3_0 >= '\u0000' && LA3_0 <= '\t') ||
                                            (LA3_0 >= '\u000B' && LA3_0 <= '\f') ||
                                                (LA3_0 >= '\u000E' && LA3_0 <= '\uFFFF')))
                                        {
                                            alt3 = 1;
                                        }
                                    }
                                    finally
                                    {
                                        DebugExitDecision(3);
                                    }
                                    switch (alt3)
                                    {
                                        case 1:
                                            DebugEnterAlt(1);
                                            // /Users/abdullin/MessageContracts.g:
                                            {
                                                DebugLocation(88, 14);
                                                input.Consume();
                                            }
                                            break;

                                        default:
                                            goto loop3;
                                    }
                                }

                                loop3:
                                ;
                            }
                            finally
                            {
                                DebugExitSubRule(3);
                            }

                            DebugLocation(88, 28);
                            // /Users/abdullin/MessageContracts.g:88:28: ( '\\r' )?
                            int alt4 = 2;
                            try
                            {
                                DebugEnterSubRule(4);
                                try
                                {
                                    DebugEnterDecision(4, decisionCanBacktrack[4]);
                                    int LA4_0 = input.LA(1);

                                    if ((LA4_0 == '\r'))
                                    {
                                        alt4 = 1;
                                    }
                                }
                                finally
                                {
                                    DebugExitDecision(4);
                                }
                                switch (alt4)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        // /Users/abdullin/MessageContracts.g:88:28: '\\r'
                                        {
                                            DebugLocation(88, 28);
                                            Match('\r');
                                        }
                                        break;
                                }
                            }
                            finally
                            {
                                DebugExitSubRule(4);
                            }

                            DebugLocation(88, 34);
                            Match('\n');
                            DebugLocation(88, 39);
                            _channel = HIDDEN;
                        }
                        break;
                    case 2:
                        DebugEnterAlt(2);
                        // /Users/abdullin/MessageContracts.g:89:9: '/*' ( options {greedy=false; } : . )* '*/'
                        {
                            DebugLocation(89, 9);
                            Match("/*");

                            DebugLocation(89, 14);
                            // /Users/abdullin/MessageContracts.g:89:14: ( options {greedy=false; } : . )*
                            try
                            {
                                DebugEnterSubRule(5);
                                while (true)
                                {
                                    int alt5 = 2;
                                    try
                                    {
                                        DebugEnterDecision(5, decisionCanBacktrack[5]);
                                        int LA5_0 = input.LA(1);

                                        if ((LA5_0 == '*'))
                                        {
                                            int LA5_1 = input.LA(2);

                                            if ((LA5_1 == '/'))
                                            {
                                                alt5 = 2;
                                            }
                                            else if (((LA5_1 >= '\u0000' && LA5_1 <= '.') ||
                                                (LA5_1 >= '0' && LA5_1 <= '\uFFFF')))
                                            {
                                                alt5 = 1;
                                            }
                                        }
                                        else if (((LA5_0 >= '\u0000' && LA5_0 <= ')') ||
                                            (LA5_0 >= '+' && LA5_0 <= '\uFFFF')))
                                        {
                                            alt5 = 1;
                                        }
                                    }
                                    finally
                                    {
                                        DebugExitDecision(5);
                                    }
                                    switch (alt5)
                                    {
                                        case 1:
                                            DebugEnterAlt(1);
                                            // /Users/abdullin/MessageContracts.g:89:42: .
                                            {
                                                DebugLocation(89, 42);
                                                MatchAny();
                                            }
                                            break;

                                        default:
                                            goto loop5;
                                    }
                                }

                                loop5:
                                ;
                            }
                            finally
                            {
                                DebugExitSubRule(5);
                            }

                            DebugLocation(89, 47);
                            Match("*/");

                            DebugLocation(89, 52);
                            _channel = HIDDEN;
                        }
                        break;
                }
                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("COMMENT", 12);
                LeaveRule("COMMENT", 12);
                LeaveRule_COMMENT();
            }
        }

        // $ANTLR end "COMMENT"

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_WS() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_WS() {}

        // $ANTLR start "WS"
        [GrammarRule("WS")]
        void mWS()
        {
            EnterRule_WS();
            EnterRule("WS", 13);
            TraceIn("WS", 13);
            try
            {
                int _type = WS;
                int _channel = DefaultTokenChannel;
                // /Users/abdullin/MessageContracts.g:92:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
                DebugEnterAlt(1);
                // /Users/abdullin/MessageContracts.g:92:9: ( ' ' | '\\t' | '\\r' | '\\n' )
                {
                    DebugLocation(92, 9);
                    if ((input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ')
                    {
                        input.Consume();
                    }
                    else
                    {
                        MismatchedSetException mse = new MismatchedSetException(null, input);
                        DebugRecognitionException(mse);
                        Recover(mse);
                        throw mse;
                    }

                    DebugLocation(96, 11);
                    _channel = HIDDEN;
                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("WS", 13);
                LeaveRule("WS", 13);
                LeaveRule_WS();
            }
        }

        // $ANTLR end "WS"

        public override void mTokens()
        {
            // /Users/abdullin/MessageContracts.g:1:8: ( T__23 | T__24 | T__25 | T__26 | T__27 | USING | LET | ENTITY | ID | Modifier | INT | COMMENT | WS )
            int alt7 = 13;
            try
            {
                DebugEnterDecision(7, decisionCanBacktrack[7]);
                switch (input.LA(1))
                {
                    case '(':
                        {
                            alt7 = 1;
                        }
                        break;
                    case ')':
                        {
                            alt7 = 2;
                        }
                        break;
                    case ',':
                        {
                            alt7 = 3;
                        }
                        break;
                    case ';':
                        {
                            alt7 = 4;
                        }
                        break;
                    case '=':
                        {
                            alt7 = 5;
                        }
                        break;
                    case 'u':
                        {
                            int LA7_6 = input.LA(2);

                            if ((LA7_6 == 's'))
                            {
                                int LA7_15 = input.LA(3);

                                if ((LA7_15 == 'i'))
                                {
                                    int LA7_18 = input.LA(4);

                                    if ((LA7_18 == 'n'))
                                    {
                                        int LA7_21 = input.LA(5);

                                        if ((LA7_21 == 'g'))
                                        {
                                            int LA7_24 = input.LA(6);

                                            if (((LA7_24 >= '0' && LA7_24 <= '9') || LA7_24 == '<' || LA7_24 == '>' ||
                                                (LA7_24 >= 'A' && LA7_24 <= '[') || LA7_24 == ']' || LA7_24 == '_' ||
                                                    (LA7_24 >= 'a' && LA7_24 <= 'z')))
                                            {
                                                alt7 = 9;
                                            }
                                            else
                                            {
                                                alt7 = 6;
                                            }
                                        }
                                        else
                                        {
                                            alt7 = 9;
                                        }
                                    }
                                    else
                                    {
                                        alt7 = 9;
                                    }
                                }
                                else
                                {
                                    alt7 = 9;
                                }
                            }
                            else
                            {
                                alt7 = 9;
                            }
                        }
                        break;
                    case 'l':
                        {
                            int LA7_7 = input.LA(2);

                            if ((LA7_7 == 'e'))
                            {
                                int LA7_16 = input.LA(3);

                                if ((LA7_16 == 't'))
                                {
                                    int LA7_19 = input.LA(4);

                                    if (((LA7_19 >= '0' && LA7_19 <= '9') || LA7_19 == '<' || LA7_19 == '>' ||
                                        (LA7_19 >= 'A' && LA7_19 <= '[') || LA7_19 == ']' || LA7_19 == '_' ||
                                            (LA7_19 >= 'a' && LA7_19 <= 'z')))
                                    {
                                        alt7 = 9;
                                    }
                                    else
                                    {
                                        alt7 = 7;
                                    }
                                }
                                else
                                {
                                    alt7 = 9;
                                }
                            }
                            else
                            {
                                alt7 = 9;
                            }
                        }
                        break;
                    case 'e':
                        {
                            int LA7_8 = input.LA(2);

                            if ((LA7_8 == 'n'))
                            {
                                int LA7_17 = input.LA(3);

                                if ((LA7_17 == 't'))
                                {
                                    int LA7_20 = input.LA(4);

                                    if ((LA7_20 == 'i'))
                                    {
                                        int LA7_23 = input.LA(5);

                                        if ((LA7_23 == 't'))
                                        {
                                            int LA7_25 = input.LA(6);

                                            if ((LA7_25 == 'y'))
                                            {
                                                int LA7_27 = input.LA(7);

                                                if (((LA7_27 >= '0' && LA7_27 <= '9') || LA7_27 == '<' || LA7_27 == '>' ||
                                                    (LA7_27 >= 'A' && LA7_27 <= '[') || LA7_27 == ']' || LA7_27 == '_' ||
                                                        (LA7_27 >= 'a' && LA7_27 <= 'z')))
                                                {
                                                    alt7 = 9;
                                                }
                                                else
                                                {
                                                    alt7 = 8;
                                                }
                                            }
                                            else
                                            {
                                                alt7 = 9;
                                            }
                                        }
                                        else
                                        {
                                            alt7 = 9;
                                        }
                                    }
                                    else
                                    {
                                        alt7 = 9;
                                    }
                                }
                                else
                                {
                                    alt7 = 9;
                                }
                            }
                            else
                            {
                                alt7 = 9;
                            }
                        }
                        break;
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                    case 'G':
                    case 'H':
                    case 'I':
                    case 'J':
                    case 'K':
                    case 'L':
                    case 'M':
                    case 'N':
                    case 'O':
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                    case 'T':
                    case 'U':
                    case 'V':
                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                    case '_':
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'm':
                    case 'n':
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        {
                            alt7 = 9;
                        }
                        break;
                    case '!':
                    case '$':
                    case '+':
                    case '-':
                    case ':':
                    case '?':
                    case '@':
                        {
                            alt7 = 10;
                        }
                        break;
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        {
                            alt7 = 11;
                        }
                        break;
                    case '/':
                        {
                            alt7 = 12;
                        }
                        break;
                    case '\t':
                    case '\n':
                    case '\r':
                    case ' ':
                        {
                            alt7 = 13;
                        }
                        break;
                    default:
                        {
                            NoViableAltException nvae = new NoViableAltException("", 7, 0, input);
                            DebugRecognitionException(nvae);
                            throw nvae;
                        }
                }
            }
            finally
            {
                DebugExitDecision(7);
            }
            switch (alt7)
            {
                case 1:
                    DebugEnterAlt(1);
                    // /Users/abdullin/MessageContracts.g:1:10: T__23
                    {
                        DebugLocation(1, 10);
                        mT__23();
                    }
                    break;
                case 2:
                    DebugEnterAlt(2);
                    // /Users/abdullin/MessageContracts.g:1:16: T__24
                    {
                        DebugLocation(1, 16);
                        mT__24();
                    }
                    break;
                case 3:
                    DebugEnterAlt(3);
                    // /Users/abdullin/MessageContracts.g:1:22: T__25
                    {
                        DebugLocation(1, 22);
                        mT__25();
                    }
                    break;
                case 4:
                    DebugEnterAlt(4);
                    // /Users/abdullin/MessageContracts.g:1:28: T__26
                    {
                        DebugLocation(1, 28);
                        mT__26();
                    }
                    break;
                case 5:
                    DebugEnterAlt(5);
                    // /Users/abdullin/MessageContracts.g:1:34: T__27
                    {
                        DebugLocation(1, 34);
                        mT__27();
                    }
                    break;
                case 6:
                    DebugEnterAlt(6);
                    // /Users/abdullin/MessageContracts.g:1:40: USING
                    {
                        DebugLocation(1, 40);
                        mUSING();
                    }
                    break;
                case 7:
                    DebugEnterAlt(7);
                    // /Users/abdullin/MessageContracts.g:1:46: LET
                    {
                        DebugLocation(1, 46);
                        mLET();
                    }
                    break;
                case 8:
                    DebugEnterAlt(8);
                    // /Users/abdullin/MessageContracts.g:1:50: ENTITY
                    {
                        DebugLocation(1, 50);
                        mENTITY();
                    }
                    break;
                case 9:
                    DebugEnterAlt(9);
                    // /Users/abdullin/MessageContracts.g:1:57: ID
                    {
                        DebugLocation(1, 57);
                        mID();
                    }
                    break;
                case 10:
                    DebugEnterAlt(10);
                    // /Users/abdullin/MessageContracts.g:1:60: Modifier
                    {
                        DebugLocation(1, 60);
                        mModifier();
                    }
                    break;
                case 11:
                    DebugEnterAlt(11);
                    // /Users/abdullin/MessageContracts.g:1:69: INT
                    {
                        DebugLocation(1, 69);
                        mINT();
                    }
                    break;
                case 12:
                    DebugEnterAlt(12);
                    // /Users/abdullin/MessageContracts.g:1:73: COMMENT
                    {
                        DebugLocation(1, 73);
                        mCOMMENT();
                    }
                    break;
                case 13:
                    DebugEnterAlt(13);
                    // /Users/abdullin/MessageContracts.g:1:81: WS
                    {
                        DebugLocation(1, 81);
                        mWS();
                    }
                    break;
            }
        }

        #region DFA

        protected override void InitDFAs()
        {
            base.InitDFAs();
        }

        #endregion
    }
}

// namespace  MessageContracts 